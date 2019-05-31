﻿using UnityEngine;

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

    public void AddToFearSetter(GameObject go)
    {
        player1.GetComponent<FearSetter>().hittables.Add(go);
        player2.GetComponent<FearSetter>().hittables.Add(go);
    }
    
    public void RemoveFromFearSetter(GameObject go)
    {
        player1.GetComponent<FearSetter>().hittables.Remove(go);
        player2.GetComponent<FearSetter>().hittables.Remove(go);
    }
}