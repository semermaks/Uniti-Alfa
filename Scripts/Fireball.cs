using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
	[SerializeField] private Rigidbody2D rb2d = null;
	[SerializeField] private float fireballForce = 5f;
	[SerializeField] private float lifeTime = 3f;

	[SerializeField] private TriggerDamage triggerDamage = null;
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void SetImpulse(float forceDirection, GameObject parent)
	{
		if(forceDirection < 0)
		{
			transform.rotation = Quaternion.Euler(0, 180, 0);
		}
		triggerDamage.Parent = parent;
		rb2d.AddForce(Vector2.right * fireballForce * forceDirection, ForceMode2D.Impulse);
		StartCoroutine(StartLife());
	}

	private IEnumerator StartLife()
	{
		yield return new WaitForSeconds(lifeTime);
		Destroy(gameObject);

		yield break;
	}
}
