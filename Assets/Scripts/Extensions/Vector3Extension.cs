using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Vector3Extension
{
    public static Vector3 SetZ(this Vector3 vec1, float z)
    {
        return new Vector3(vec1.x, vec1.y, z);
    }
}
