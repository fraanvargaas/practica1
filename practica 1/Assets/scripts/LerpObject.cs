using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpObject : MonoBehaviour
{
	public Transform objectToMove;
	public Transform initialPos, finalPos;
	public float TimeToLerp = 5;
	private float elapsedTime = 0;

	// Update is called once per frame
	private void Update()
	{
		elapsedTime += Time.deltaTime;
		float lerpPercentage = elapsedTime / TimeToLerp;
		objectToMove.position = Vector3.Lerp(initialPos.position, finalPos.position, lerpPercentage);
		if (elapsedTime > TimeToLerp)
		{
			elapsedTime = 0;
			swap();
		}
	}

	public void swap()
	{
		Transform temp = initialPos;
		initialPos = finalPos;
		finalPos = temp;
	}
}