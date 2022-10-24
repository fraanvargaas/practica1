using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
	public int currentNumberOfCoins;

	public Text CoinText;

	public void GetCoins(int cointAmount)
	{
		currentNumberOfCoins += cointAmount;
		if (CoinText != null)
		{
			CoinText.text = currentNumberOfCoins.ToString();
		}
		else
		{
			Debug.LogError("Acuerdate de pasar el objeto en Unity");
		}

		Debug.Log("he recogido una moneda, tengo: " + currentNumberOfCoins + "monedas");
	}
}