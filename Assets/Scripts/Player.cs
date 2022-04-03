using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float playerSpeed;
    private Vector2 playerDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = CrossPlatformInputManager.GetAxis("Vertical") * playerSpeed * Time.deltaTime;
        playerDirection = new Vector2(0, directionY).normalized;
    }

	private void FixedUpdate()
	{
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
	}

}
