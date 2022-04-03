using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpDown : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed;
    //private Player player;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //player = FindObjectOfType<Player>();
        moveSpeed = 12f;
    }

    public void MoveUp()
    {
        rb.velocity = Vector2.up * moveSpeed;
    }

    public void MoveDown()
    {
        rb.velocity = Vector2.up * -moveSpeed;
    }

    public void StopMoving()
    {
        rb.velocity = Vector2.zero;
    }
}
