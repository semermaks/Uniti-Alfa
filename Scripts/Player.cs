using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	[SerializeField] private float speed = 2.5f;
	[SerializeField] private Rigidbody2D playerRigidbody;
	[SerializeField] private float force = 2.0f;
	[SerializeField] private float minHeight;
	[SerializeField] private GroundDetection groundDetection;
	[SerializeField] private Vector3 direction;
	[SerializeField] private Animator animator;
	[SerializeField] private SpriteRenderer spriteRenderer;
	private bool isJumping;

	[SerializeField] private GameObject fireball = null;
	[SerializeField] private Transform fireballSpawnPoint = null;
	[SerializeField] private float shootForce = 5f;

	private void FixedUpdate()
	{
		animator.SetBool("isGrounded", groundDetection.isGrounded);
		direction = Vector3.zero;

		if (Input.GetKey(KeyCode.A))
		{
			direction = Vector3.left;
			spriteRenderer.flipX = true;
		}
		if (Input.GetKey(KeyCode.D))
		{
			direction = Vector3.right;
			spriteRenderer.flipX = false;
		}
		if (direction.x > 0.1)
		{
		}
		if (direction.x < 0.1)
		{
		}
		direction *= speed;
		direction.y = playerRigidbody.velocity.y;
		playerRigidbody.velocity = direction;
		if (Input.GetKeyDown(KeyCode.Space) && groundDetection.isGrounded)
		{
			playerRigidbody.AddForce(Vector2.up * force, ForceMode2D.Impulse);
			animator.SetTrigger("StartJump");
			isJumping = true;
		}
		animator.SetFloat("Speed", Mathf.Abs(direction.x));
		if (!isJumping && !groundDetection.isGrounded)
		{
			animator.SetTrigger("StartFall");
		}
		isJumping = isJumping && !groundDetection.isGrounded;
	}
	
	void Fire()
	{
		if (Input.GetMouseButtonDown(0))
		{
			animator.SetTrigger("Fire");
		}
	}
	private void Update()
	{
		Fire();
	}
	void CreateFireball()
	{
		GameObject bullet = Instantiate(fireball, fireballSpawnPoint.position, Quaternion.identity);

		bullet.GetComponent<Fireball>().SetImpulse(spriteRenderer.flipX ? -shootForce : shootForce, gameObject);
		StartCoroutine(StartLife());
	}
	private IEnumerator StartLife()
	{
		yield return new WaitForSeconds(2f);

		yield break;
	}
}
