using Extensions;
using UnityEngine;

public class Waver : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float height = 0.5f;

    private void Update()
    {
        Transform t = transform;
        t.position = t.position.With(y: Mathf.Sin(Time.time * speed * height));
    }
}
