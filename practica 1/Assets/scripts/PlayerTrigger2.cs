using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
	private string playerTag = "Player";

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag(playerTag))
		{
			OnPlayerEnter(other.gameObject);
		}
	}

	public virtual void OnPlayerEnter(GameObject playerObject)
	{
	}
}