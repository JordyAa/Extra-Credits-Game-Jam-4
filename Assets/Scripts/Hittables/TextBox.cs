using UnityEngine;

public class TextBox
{
    public readonly bool isPositive;
    public readonly Platform platform;

    public TextBox(bool isPositive, Platform? platform = null)
    {
        this.isPositive = isPositive;
        this.platform = platform ?? (Platform) Random.Range(0, 3);
    }
}

public enum Platform
{
    Facebook,
    Reddit,
    Snapchat,
    Twitter
}
