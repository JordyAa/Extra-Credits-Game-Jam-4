using UnityEngine;

public static class Vector2Extensions
{
    public static Vector2 With(this Vector2 original, float? x = null, float? y = null)
    {
        return new Vector2(x ?? original.x, y ?? original.y);
    }
    
    public static Vector2 CenterTo(this Vector2 from, Vector2 to)
    {
        return new Vector2((from.x + to.x) / 2f, (from.y + to.y) / 2f);
    }
    
    public static float AngleTo(this Vector2 from, Vector2 to)
    {
        return Mathf.Atan2(to.y - from.y, to.x - from.x) * 180f / Mathf.PI;
    }
}