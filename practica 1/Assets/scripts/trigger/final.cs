using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class final : PlayerTrigger
{
	public override void OnPlayerEnter(GameObject playerObject)
	{
		LevelManager levelManager = GetComponent<LevelManager>();
		levelManager.NextLevel();
	}
}