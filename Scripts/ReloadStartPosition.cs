using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadStartPosition : MonoBehaviour
{
	public float startX;
	public float startY;
	public Rigidbody2D player;
	
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.F9))
		{
			ReloadPosition();
		}
	}
	public void ReloadPosition()
	{

		player.position = new Vector2(startX, startY);
		player.velocity = new Vector2(0, 0);
	}
}
