using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turbo : MonoBehaviour {
	public static float tiempoDoblar = 0.0f;
	public static bool izquierda = false;
	public static bool derecha = false;
	public static float turbo = 1f;
	public static bool verdadTrubo = false;
	// Use this for initialization
	void Start () {
		tiempoDoblar = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (turbo == 2f) {
			turbo = 1f;
		} else if (Input.GetKeyDown (KeyCode.LeftArrow) && derecha == false) {
			izquierda = true;
			tiempoDoblar = tiempoDoblar + Time.deltaTime;
		} else if (Input.GetKeyUp (KeyCode.LeftArrow) && tiempoDoblar > 0.5f && izquierda == true) {
			tiempoDoblar = 0.0f;
			turbo = 2f;
			izquierda = false;

		} else if (Input.GetKeyDown (KeyCode.RightArrow) && izquierda == false) {
			derecha = true;
			tiempoDoblar = tiempoDoblar + Time.deltaTime;
		} else if (Input.GetKeyUp (KeyCode.RightArrow) && tiempoDoblar > 0.5f && derecha == true) {
			tiempoDoblar = 0.0f;
			turbo = 2f;
			derecha = false;
		}
	}
}
