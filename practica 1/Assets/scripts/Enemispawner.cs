using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemispawner : MonoBehaviour
{
	public GameObject enemiPerfav;

	public Transform[] spawnPosition;

	public float timeToSpawn = 5f;

	private float timeSinceLastSpawn;

	// Update is called once per frame
	private void Update()
	{
		timeSinceLastSpawn += Time.deltaTime;
		if (timeSinceLastSpawn > timeToSpawn)
		{
			timeSinceLastSpawn = 0;
			int rand = Random.Range(0, spawnPosition.Length);
			Transform randonpos = spawnPosition[rand];
			Instantiate(enemiPerfav, randonpos.position, Quaternion.identity);
		}
	}
}