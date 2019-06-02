using UnityEngine;

public class Scroller : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float destroyPoint = -10f;

    private void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0f, 0f);

        if (destroyPoint < 0 && transform.position.x < destroyPoint ||
            destroyPoint > 0 && transform.position.x > 2f * destroyPoint)
        {
            PlayerManager.instance.RemoveFromFearSetter(gameObject);
            Destroy(gameObject);
        }
    }
}
