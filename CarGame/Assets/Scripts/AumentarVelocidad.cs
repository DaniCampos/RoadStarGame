using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AumentarVelocidad : MonoBehaviour {
	public static float vueltas = 1f;
	void Start (){
		vueltas = 1;
	}
	void OnTriggerEnter(Collider Choque) {
		vueltas++;
	}
		
}
