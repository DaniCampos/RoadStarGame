﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour {

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.P)) {
			if (Time.timeScale == 1)
				Time.timeScale = 0;
			else
				Time.timeScale = 1;
		}

	}
}
