using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoin : MonoBehaviour
{
	[SerializeField] private Animator animator;
	public void StartDestdoy()
	{
		animator.SetTrigger("Destroy");
	}

	public void EndDestdoy()
	{
		Destroy(gameObject);
	}
}
