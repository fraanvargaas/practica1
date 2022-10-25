using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotation : MonoBehaviour
{
	private float RotationSpeedY = 2;

	private string playerTag = "Player";

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag(playerTag))
		{
		}
	}
}

//transform.Rotate(rotationSpeedX * Time.deltaTime, RotationSpeedY * Time.deltaTime,
//	RotationSpeedZ * Time.deltaTime);