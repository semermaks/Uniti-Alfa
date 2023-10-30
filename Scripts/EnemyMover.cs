using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
	public float speed = 1.0f;
	public bool isRightDirection;
	Rigidbody2D rb2d;
	public GroundDetection groundDetection;
	public SpriteRenderer spriteRenderer;
	// Start is called before the first frame update
	void Start()
    {
		rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
		if (isRightDirection && groundDetection.isGrounded)
		{
			rb2d.velocity = Vector2.right * speed;
			spriteRenderer.flipX = false;
		}
		else if(groundDetection.isGrounded)
		{
			rb2d.velocity = Vector2.left * speed;
			spriteRenderer.flipX = true;
		}
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.CompareTag("left") || collision.gameObject.CompareTag("right"))
		{
			isRightDirection = !isRightDirection;
		}
	}
}
