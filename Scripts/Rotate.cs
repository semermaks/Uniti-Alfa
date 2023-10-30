using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
	public float rotateSpeed = 1.0f;

	public void Update()
	{
		transform.Rotate(new Vector3(0, 1, 0) * rotateSpeed);
	}
}
