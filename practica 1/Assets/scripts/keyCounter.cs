using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyCounter : MonoBehaviour
{
	public int currentNumberOfCoins;

	public Text KeyText;

	public void GetCoins(int cointAmount)
	{
		currentNumberOfCoins += cointAmount;
		if (KeyText != null)
		{
			KeyText.text = currentNumberOfCoins.ToString();
		}
		else
		{
			Debug.LogError("Acuerdate de pasar el objeto en Unity");
		}

		Debug.Log("he recogido una llave, tengo: " + currentNumberOfCoins + "llaves");
	}
}