using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
	public GameObject boton;
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.LeftAlt))
		{
			boton.SetActive(true);
			Cursor.lockState = CursorLockMode.None;
			Time.timeScale = 0;
		}
		if (Input.GetKeyUp(KeyCode.LeftAlt))
        {
			boton.SetActive(false);
			Cursor.lockState = CursorLockMode.Locked;
			Time.timeScale = 1;
        }
		
			
	}
}

 