using UnityEngine;

public static class VectorExtensions
{
    public static Vector3 VectorMa(Vector3 start, float scale, Vector3 direction)
    {
        var dest = new Vector3()
        {
            x = start.x + direction.x * scale,
            y = start.y + direction.y * scale,
            z = start.z + direction.z * scale
        };
        return dest;
    }
}