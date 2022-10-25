using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puertaPrincipal : MonoBehaviour
{
	public Animator lapuerta;
	private bool enzona;
	private bool activa;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.E) && enzona == true)
		{
			activa = !activa;
			if (activa == true)
			{
				lapuerta.SetBool("puertaActiv", true);
			}
			if (activa == false)
			{
				lapuerta.SetBool("puertaActiv", false);
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
			_ = enzona == false;
		}
	}
}