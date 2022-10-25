using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
	private string playerTag = "Player";
	public Transform InitialPosition;
    

    private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag(playerTag))
		{
       
		}
	}
}
