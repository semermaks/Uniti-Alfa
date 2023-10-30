using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
	public int health;
    
	public void AddHealth(int add)
	{
		health += add;
		if (health > 100) health = 100;
	}

	public void SubstractHealth(int subst)
	{
		health -= subst;
		if (health <= 0) Destroy(gameObject);
	}
}
