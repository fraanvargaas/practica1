using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ascensor : MonoBehaviour
{
	public Animator ascensorAnim;
	private bool enzona;
	private bool activa;
	
	private void Update()
	{
		if (enzona == true)
		{
			activa = !activa;
			if (activa == true)
			{
				ascensorAnim.SetBool("ascensor", true);
				
			}

		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			enzona = true;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player")
		{
			enzona = false;
			ascensorAnim.SetBool("ascensor", false);
			
		}
	}
}
