using UnityEngine;
using System.Collections;

public class HealthBarControl : MonoBehaviour {
	private SpriteRenderer healthBar;			// Reference to the sprite renderer of the health bar.
	private Vector3 healthScale;
	void Awake ()
	{
		healthBar = GetComponentInChildren<SpriteRenderer>();
		healthScale = healthBar.transform.localScale;
	}

	
	public void UpdateHealthBar (float health)
	{
		// Set the health bar's colour to proportion of the way between green and red based on the player's health.
		healthBar.material.color = Color.Lerp(Color.green, Color.red, 1 - health * 0.01f);
		
		// Set the scale of the health bar to be proportional to the player's health.
		healthBar.transform.localScale = new Vector3(healthScale.x * health * 0.01f, 1, 1);
	}
}
