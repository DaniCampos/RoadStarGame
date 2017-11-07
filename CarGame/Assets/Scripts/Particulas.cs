using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particulas : MonoBehaviour {
	public static float tiempoTurbo = 0.0f;
	public ParticleSystem system;
	void Start () {
		tiempoTurbo = 0.0f;	
	}
	
	// Update is called once per frame
	void Update () {
		if (Turbo.verdadTrubo == true && tiempoTurbo < 5f) {
			tiempoTurbo = tiempoTurbo + Time.deltaTime;
			var emitParams = new ParticleSystem.EmitParams ();
			emitParams.startColor = Color.red;
			emitParams.startSize = 0.2f;
			system.Emit (emitParams, 10);
			system.Play (); // Continue normal emissions
		} else if (tiempoTurbo > 5f) {
			Turbo.verdadTrubo = false;
			tiempoTurbo = 0f;
		}
	}
}
