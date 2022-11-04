using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
	public int MaxHealth;
	private int currentHealth;

	private Vector3 InitialPosition;

	public Text healthText;

	private void Start()
	{
		InitialPosition = transform.position;
		currentHealth = MaxHealth;
		if (healthText != null)
		{
			healthText.text = currentHealth.ToString();
		}
	}

	public void TakeDamage(int damageTaken)
	{
		currentHealth -= damageTaken;
		if (healthText != null)
		{
			healthText.text = currentHealth.ToString();
		}

		if (currentHealth <= 0)
		{
			//Debug.Log("estoy muerto");
			//transform.position = InitialPosition;
			//currentHealth = MaxHealth;
			//healthText.text = currentHealth.ToString();
			die();
		}
		else
		{
			Debug.Log("me han echo da�o, salud restante " + currentHealth);
		}
	}

	public virtual void die()
	{
	}
}