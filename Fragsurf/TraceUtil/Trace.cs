using UnityEngine;

namespace Fragsurf.TraceUtil
{
    public struct Trace
    {
        public Vector3 StartPos;
        public Vector3 EndPos;
        public float Fraction;
        public bool StartSolid;
        public Collider HitCollider;
        public Vector3 HitPoint;
        public Vector3 PlaneNormal;
    }
}
