using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
	public float timetodestroy = 2;

	private void Start()
	{
		Destroy(gameObject, timetodestroy);
	}
}