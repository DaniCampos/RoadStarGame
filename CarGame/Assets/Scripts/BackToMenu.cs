﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.M))
			SceneManager.LoadScene (0);

	}
}
