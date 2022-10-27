using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogo : PlayerTrigger
{
	private bool enzona;
	public GameObject dialogos;
	

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.E) && enzona == true)
		{
			dialogos.SetActive(true);
			Cursor.lockState = CursorLockMode.None;
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
