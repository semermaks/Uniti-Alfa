using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
	public int totalAmountofGemAtLevel;

	public int curGemCount;
	public int Money;

	public bool isTriggered;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Gem") && isTriggered) 
		{
			Destroy(collision.gameObject);
			curGemCount++;
			isTriggered = false;
		}
		if (collision.gameObject.CompareTag("coinBronze") && isTriggered)
		{
			var money = collision.gameObject.GetComponent<DestroyCoin>();
			money.StartDestdoy();
			Money += 1;
			isTriggered = false;
		}
		if (collision.gameObject.CompareTag("coinSilver") && isTriggered)
		{
			var money = collision.gameObject.GetComponent<DestroyCoin>();
			money.StartDestdoy();
			Money += 5;
			isTriggered = false;
		}
		if (collision.gameObject.CompareTag("coinGold") && isTriggered)
		{
			var money = collision.gameObject.GetComponent<DestroyCoin>();
			money.StartDestdoy();
			Money += 10;
			isTriggered = false;

		}
	}

	private void OnTriggerStay2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Door") && curGemCount >= totalAmountofGemAtLevel)
		{
			Debug.Log("Victory!");
		}
	}
	public void Update()
	{
		isTriggered = true;
	}
}
