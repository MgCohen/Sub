using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Extensions
{
  public static Vector2Int ToVector2Int(this Vector2 v)
  {
    return new Vector2Int((int) v.x, (int) v.y);
  }

  public static Vector2Int ToVector2Int(this Vector3 v)
  {
    return new Vector2Int((int) v.x, (int) v.y);
  }

  public static Vector2 RoundToInt(this Vector2 v)
  {
    return new Vector2((int)v.x,(int) v.y);
  }

  public static Vector2 RoundToInt(this Vector3 v)
  {
    return new Vector2((int) v.x, (int) v.y);
  }
  
}
