using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDetected : MonoBehaviour
{
	public int damage;
	public string damageTargetTag;
	public bool resetPosition = false;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag(damageTargetTag))
		{
			Health health = collision.gameObject.GetComponent<Health>();
			health.SubstractHealth(damage);

			if (resetPosition)
			{
				collision.gameObject.GetComponent<ReloadStartPosition>().ReloadPosition();
			}
		}
	}
}
