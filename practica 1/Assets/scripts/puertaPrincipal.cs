using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puertaPrincipal : MonoBehaviour
{

	public Animator lapuerta;
	private bool enzona;
	private bool activa;
	public GameObject sonido;
	public GameObject sonido2;
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.E) && enzona == true)
		{
			activa = !activa;
			if (activa == true)
			{
				lapuerta.SetBool("puertaActiv", true);
				sonido.SetActive(true);
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
			lapuerta.SetBool("puertaActiv", false);
			sonido2.SetActive(true);
		}
	}
}

