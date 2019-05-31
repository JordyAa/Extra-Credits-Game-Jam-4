using UnityEngine;

[CreateAssetMenu(menuName="Text Box", fileName="New Text Box")]
public class TextBox : ScriptableObject
{
    public Platform platform;
    public bool isPositive;

    public string person = "NEW NAME";
    public string text = "NEW MESSAGE";
}

public enum Platform
{
    Facebook,
    Reddit,
    Snapchat,
    Twitter
}
