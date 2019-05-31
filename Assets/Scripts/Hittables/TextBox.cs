using UnityEngine;

[CreateAssetMenu(menuName="Text Box", fileName="New Text Box")]
public class TextBox : ScriptableObject
{
    public Platform platform;
    public bool isPositive;
}

public enum Platform
{
    Facebook,
    Reddit,
    Snapchat,
    Twitter
}
