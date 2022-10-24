using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleMoviment : MonoBehaviour
{
	public float time = 0;

	public float movingSpeed;

	private void Update()
	{
		transform.position += transform.forward * Time.deltaTime * movingSpeed;
	}
}