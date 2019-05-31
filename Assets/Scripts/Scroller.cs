using UnityEngine;

public class Scroller : MonoBehaviour
{
    public float speed = 1f;

    private void Update()
    {
        transform.Translate(0f, -speed * Time.deltaTime, 0f);
    }
}
