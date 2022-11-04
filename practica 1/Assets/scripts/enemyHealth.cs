using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : health
{
	public override void die()
	{
		Destroy(gameObject);
	}
}