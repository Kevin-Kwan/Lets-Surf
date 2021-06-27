using UnityEngine;

namespace Fragsurf.Movement
{
    public interface ISurfControllable
    {
        MoveType MoveType { get; }
        MoveData MoveData { get; }
        Collider Collider { get; }
        GameObject GroundObject { get; set; }
        Vector3 Forward { get; }
        Vector3 Right { get; }
        Vector3 Up { get; }
        Vector3 BaseVelocity { get; }
    }
}
