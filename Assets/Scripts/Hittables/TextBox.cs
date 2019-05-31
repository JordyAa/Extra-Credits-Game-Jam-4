using UnityEngine;

[CreateAssetMenu(menuName="Text Box", fileName="New Text Box")]
public class TextBox : ScriptableObject
{
    public bool isPositive;
    public Platform platform;
}

public enum Platform
{
    Facebook,
    Reddit,
    Snapchat,
    Twitter
}
