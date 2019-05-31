using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance { get; private set; }

    public Transform player1;
    public Transform player2;
    public Transform playerLine;
    
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

    public void AddToFearSetter(Transform hittable)
    {
        player1.GetComponent<FearSetter>().hittables.Add(hittable);
        player2.GetComponent<FearSetter>().hittables.Add(hittable);
    }
    
    public void RemoveFromFearSetter(Transform hittable)
    {
        player1.GetComponent<FearSetter>().hittables.Remove(hittable);
        player2.GetComponent<FearSetter>().hittables.Remove(hittable);
    }
}
