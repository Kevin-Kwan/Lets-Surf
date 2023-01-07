using UnityEngine;
using Fragsurf.TraceUtil;

namespace Fragsurf.Movement
{
    public class SurfController
    {

        ///// Fields /////

        private ISurfControllable _surfer;
        private MovementConfig _config;
        private float _deltaTime;
        public bool bruh;
        ///// Methods /////

        /// <summary>
        /// 
        /// </summary>
        public void ProcessMovement(ISurfControllable surfer, MovementConfig config, float deltaTime)
        {
            // cache instead of passing around parameters
            _surfer = surfer;
            _config = config;
            _deltaTime = deltaTime;
            
            
            // apply gravity
            if (_surfer.GroundObject == null)
            {
                _surfer.MoveData.Velocity.y -= (_surfer.MoveData.GravityFactor * _config.Gravity * _deltaTime);
                _surfer.MoveData.Velocity.y += _surfer.BaseVelocity.y * _deltaTime;
            }

            // input velocity, check for ground
            bruh=CheckGrounded();
            CalculateMovementVelocity();

            // increment origin
            _surfer.MoveData.Origin += _surfer.MoveData.Velocity * _deltaTime;

            // don't penetrate walls
            SurfPhysics.ResolveCollisions(_surfer.Collider, ref _surfer.MoveData.Origin, ref _surfer.MoveData.Velocity);

            _surfer = null;
        }

        /// <summary>
        /// 
        /// </summary>
        private void CalculateMovementVelocity()
        {
            switch (_surfer.MoveType)
            {
                case MoveType.Walk:
                    if (_surfer.GroundObject == null)
                    {
                        // apply movement from input
                        _surfer.MoveData.Velocity += AirInputMovement();

                        // let the magic happen
                        SurfPhysics.Reflect(ref _surfer.MoveData.Velocity, _surfer.Collider, _surfer.MoveData.Origin, _deltaTime);
                    }
                    else
                    {
                        // apply movement from input
                        _surfer.MoveData.Velocity += GroundInputMovement();

                        // jump/friction
                        if (_surfer.MoveData.Buttons.HasFlag((int)InputButtons.Jump))
                        {
                            Jump();
                        }
                        else
                        {
                            var friction = _surfer.MoveData.SurfaceFriction * _config.Friction;
                            var stopSpeed = _config.StopSpeed;
                            SurfPhysics.Friction(ref _surfer.MoveData.Velocity, stopSpeed, friction, _deltaTime);
                        }
                    }

                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Vector3 GroundInputMovement()
        {
            Vector3 wishVel, wishDir;
            float wishSpeed;
            GetWishValues(out wishVel, out wishDir, out wishSpeed);

            if ((wishSpeed != 0.0f) && (wishSpeed > _config.MaxSpeed))
            {
                wishVel *= _config.MaxSpeed / wishSpeed;
                wishSpeed = _config.MaxSpeed;
            }

            wishSpeed *= _surfer.MoveData.WalkFactor;

            return SurfPhysics.Accelerate(_surfer.MoveData.Velocity, wishDir, 
                wishSpeed, _config.Accel, _deltaTime, _surfer.MoveData.SurfaceFriction);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Vector3 AirInputMovement()
        {
            Vector3 wishVel, wishDir;
            float wishSpeed;
            GetWishValues(out wishVel, out wishDir, out wishSpeed);

            if (_config.ClampAirSpeed && (wishSpeed != 0f && (wishSpeed > _config.MaxSpeed)))
            {
                wishVel = wishVel * (_config.MaxSpeed / wishSpeed);
                wishSpeed = _config.MaxSpeed;
            }

            return SurfPhysics.AirAccelerate(_surfer.MoveData.Velocity, wishDir, 
                wishSpeed, _config.AirAccel, _config.AirCap, _deltaTime);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="wishVel"></param>
        /// <param name="wishDir"></param>
        /// <param name="wishSpeed"></param>
        private void GetWishValues(out Vector3 wishVel, out Vector3 wishDir, out float wishSpeed)
        {
            wishVel = Vector3.zero;
            wishDir = Vector3.zero;
            wishSpeed = 0f;

            Vector3 forward = _surfer.Forward,
                right = _surfer.Right;

            forward[1] = 0;
            right[1] = 0;
            forward.Normalize();
            right.Normalize();

            for (int i = 0; i < 3; i++)
                wishVel[i] = forward[i] * _surfer.MoveData.ForwardMove + right[i] * _surfer.MoveData.SideMove;
            wishVel[1] = 0;

            wishSpeed = wishVel.magnitude;
            wishDir = wishVel.normalized;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="velocity"></param>
        /// <param name="jumpPower"></param>
        private void Jump()
        {
            if (!_config.AutoBhop && _surfer.MoveData.OldButtons.HasFlag((int)InputButtons.Jump))
                return;

            _surfer.MoveData.Velocity.y += _config.JumpPower;
        }

        /// <summary>
        /// 
        /// </summary>
        private bool CheckGrounded()
        {
            _surfer.MoveData.SurfaceFriction = 1f;
            var movingUp = _surfer.MoveData.Velocity.y > 0f;
            var trace = TraceToFloor();
            if (trace.HitCollider == null
                || trace.PlaneNormal.y < 0.7f
                || movingUp)
            {
                SetGround(null);
                if (movingUp && _surfer.MoveType != MoveType.Noclip)
                {
                    _surfer.MoveData.SurfaceFriction = _config.AirFriction;
                }
                return false;
            }
            else
            {
                SetGround(trace.HitCollider.gameObject);
                return true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        private void SetGround(GameObject obj)
        {
            if(obj != null)
            {
                _surfer.GroundObject = obj;
                _surfer.MoveData.Velocity.y = 0;
            }
            else
            {
                _surfer.GroundObject = null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="layerMask"></param>
        /// <returns></returns>
        private Trace TraceBounds(Vector3 start, Vector3 end, int layerMask)
        {
            return Tracer.TraceCollider(_surfer.Collider, start, end, layerMask);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Trace TraceToFloor()
        {
            var down = _surfer.MoveData.Origin;
            down.y -= 0.1f;
            return Tracer.TraceCollider(_surfer.Collider, _surfer.MoveData.Origin, down, SurfPhysics.GroundLayerMask);
        }

    }
}
