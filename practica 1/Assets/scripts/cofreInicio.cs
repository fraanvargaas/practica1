using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cofreInicio : MonoBehaviour
{
	public Animator Cofre;
	private bool enzona;
	private bool activa;
	public GameObject texto;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.E) && enzona == true)
		{
			activa = !activa;
			if (activa == true)
			{
				Cofre.SetBool("cofre", true);
			}
			if (activa == false)
			{
				Cofre.SetBool("cofre", false);
			}
			texto.SetActive(true);
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
