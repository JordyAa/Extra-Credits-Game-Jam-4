using UnityEngine;
using Newtonsoft.Json;

public class ResourcesManager : MonoBehaviour
{
    public static ResourcesManager instance { get; private set; }

    public string[] names { get; private set; }
    public string[] messagesPositive { get; private set; }
    public string[] messagesNegative { get; private set; }
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        names = JsonConvert.DeserializeObject<string[]>(Resources.Load<TextAsset>("names").ToString());
        
        messagesPositive = JsonConvert.DeserializeObject<string[]>(
            Resources.Load<TextAsset>("messages_positive").ToString());
        messagesNegative = JsonConvert.DeserializeObject<string[]>(
            Resources.Load<TextAsset>("messages_negative").ToString());
    }
}
