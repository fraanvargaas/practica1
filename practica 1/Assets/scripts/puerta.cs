using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puerta : MonoBehaviour
{
	
	public Transform puerta2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Vector3 nuevaPosicion = new Vector3(-90, 90, 0);
            puerta2.position = nuevaPosicion;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        Vector3 nuevaPosicion = new Vector3(-90, 0, 0);
        puerta2.position = nuevaPosicion;
    }
}
//private void Start()
//{
//	if (puerta3.CompareTag("Player"))
//	{
//		Vector3 nuevaPosicion = new Vector3(-90, -90, 0);
//		puerta2.position = nuevaPosicion;
//	}
