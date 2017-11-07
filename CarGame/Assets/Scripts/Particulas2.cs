using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particulas2 : MonoBehaviour {

	public static float tiempoTurbo = 0.0f;
	public GameObject bla;
	void Start ()
	{
		tiempoTurbo = 0.0f;
		bla.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Turbo.verdadTrubo == true && tiempoTurbo < 5f) {
			tiempoTurbo = tiempoTurbo + Time.deltaTime;
			bla.SetActive (true);
		} else if (tiempoTurbo > 5f) {
			Turbo.verdadTrubo = false;
			tiempoTurbo = 0f;
			bla.SetActive (true);
		}
	}
}
