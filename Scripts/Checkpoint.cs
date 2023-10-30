using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			ReloadStartPosition relPos = collision.gameObject.GetComponent<ReloadStartPosition>();
			relPos.startX = gameObject.transform.position.x;
			relPos.startY = gameObject.transform.position.y + 2;
		}
	}
}
