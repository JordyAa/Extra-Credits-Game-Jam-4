using System.Collections.Generic;
using UnityEngine;

public class FearSetter : MonoBehaviour
{
    public List<Transform> hittables = new List<Transform>();
    
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (hittables.Count > 0)
        {
            anim.SetFloat("distance", ClosestHittableDistance());
        }
    }

    private float ClosestHittableDistance()
    {
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        
        foreach (Transform t in hittables)
        {
            float curDistance = Vector2.Distance(position, t.position);
            if (curDistance < distance)
            {
                distance = curDistance;
            }
        }

        return distance;
    }
}
