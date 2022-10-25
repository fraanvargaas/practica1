using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pegar : MonoBehaviour
{
	public AnimationClip golpeo2;

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Debug.Log(golpeo2);
		}
	}
}