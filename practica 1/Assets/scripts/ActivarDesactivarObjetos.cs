using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarDesactivarObjetos : MonoBehaviour
{
	public GameObject OnOff;//para seleccionar el objeto que quieres apagar o encender 
	private string playerTag = "Player";

	private void OnTriggerEnter(Collider other) //para que cuando entres en un trigger pase algo
	{
		if (other.gameObject.CompareTag(playerTag)) //si detecta a un objeto con el tag player pase algo
		{
			OnOff.SetActive(true); //para que se apage el objeto
		}
	}
    private void OnTriggerExit(Collider other)//para que cuando salgas en un trigger pase algo
	{
		if (other.gameObject.CompareTag(playerTag))
		{
			OnOff.SetActive(false);//para que se encienda el objeto
		}
	}
}
