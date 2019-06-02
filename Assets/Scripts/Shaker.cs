using Extensions;
using UnityEngine;

public class Shaker : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float width = 0.5f;

    private Vector3 original;

    private void Start()
    {
        original = transform.localPosition;
    }

    private void Update()
    {
        Transform t = transform;
        t.localPosition = t.localPosition.With(x: original.x + Mathf.Sin(Time.time * speed * width));
    }
}
