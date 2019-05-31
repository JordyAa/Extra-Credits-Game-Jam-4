using UnityEngine;

#pragma warning disable 0649


public class DrawLine : MonoBehaviour
{
    [SerializeField] private Transform player1;
    [SerializeField] private Transform player2;

    private LineRenderer line;
    private BoxCollider2D col;

    private void Start()
    {
        line = GetComponent<LineRenderer>();
        col = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        Vector2 player1Pos = player1.position;
        Vector2 player2Pos = player2.position;

        line.SetPosition(0, player1Pos);
        line.SetPosition(1, player2Pos);

        transform.rotation = Quaternion.Euler(0f, 0f, player1Pos.AngleTo(player2Pos));

        col.transform.position = player1Pos.CenterTo(player2Pos);
        col.size = new Vector2(Vector2.Distance(player1Pos, player2Pos), col.size.y);
    }
}