using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Extensions
{
    public static Vector2Int toVector2Int(this Vector2 v)
    {
        return new Vector2Int((int)v.x, (int)v.y);
    }

    public static Vector2Int toVector2Int(this Vector3 v)
    {
        return new Vector2Int((int)v.x, (int)v.y);
    }

    public static Bounds GetBounds(this Transform target)
    {
        bool first = true;
        Bounds bound = new Bounds();
        var rend = target.GetComponent<Renderer>();
        if (rend)
        {
            bound = rend.bounds;
            first = false;
        }
        foreach (Transform child in target)
        {
            var rends = child.GetComponentsInChildren<Renderer>();
            foreach (var mRend in rends)
            {
                var tempBound = mRend.bounds;
                if (first)
                {
                    bound = tempBound;
                    first = false;
                }
                else
                {
                    bound.Encapsulate(tempBound);
                }
            }
        }
        return bound;
    }
}
