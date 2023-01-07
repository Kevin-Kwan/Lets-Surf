
namespace Fragsurf.Movement
{
    [System.Serializable]
    public class MovementConfig
    {
        public float Gravity = 15.24f;
        public float Bounce;
        public bool AutoBhop = true;
        public float AirCap = 0.575f;
        public float AirAccel = 15000;
        public float Accel = 7.62f;
        public float Friction = 4f;
        public float AirFriction = 0.25f;
        public float StopSpeed = 1.905f;
        public float JumpPower = 5.112f;
        public float BuoyancyWater = 1.905f;
        public float BuoyancySlime = 1.524f;
        public float JumpHeight = 1.5f;
        public float MaxSpeed = 6f;
        public float MaxVelocity = 100f;
        public float NoclipSpeed = 5f;
        public float NoclipAccel = 10f;
        public float StepSize = 0.5f;
        public bool ClampAirSpeed;
    }
}
