using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float dragSpeed = 1f;
    
    private Vector2 offset;
    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }

    private void OnMouseDown()
    {
        offset = transform.position - cam.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
    }

    private void OnMouseDrag()
    {
        Vector2 cursorPos = cam.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        transform.position = Vector2.Lerp(transform.position, cursorPos + offset, dragSpeed);
    }
}
