using UnityEngine;
using System.Collections;

public class HealthControl : MonoBehaviour {

	public enum Lado { Direita, Esquerda };

	public float health = 100f;
	public Lado ladoPlayer = Lado.Direita;

	private HealthBarControl healthBarControl;

	void Awake ()
	{
		if (ladoPlayer == Lado.Direita) {
			healthBarControl = GameObject.Find ("ui_healthDireita").GetComponent<HealthBarControl> ();
		} else {
			healthBarControl = GameObject.Find ("ui_healthEsquerda").GetComponent<HealthBarControl> ();
		}
	}
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		healthBarControl.UpdateHealthBar (health);
	}
}
