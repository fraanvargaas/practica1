using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cofreInicio : MonoBehaviour
{
	public Animator Cofre;
	private bool enzona;
	private bool activa;
	public GameObject texto;
	public GameObject llavefist;
	public bool llave;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.E) && enzona == true)
		{
			activa = !activa;
			if (activa == true)
			{
				Cofre.SetBool("cofre", true);
				texto.SetActive(true);
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
		}
	}
	
}
