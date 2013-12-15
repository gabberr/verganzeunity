﻿using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour {
	public Texture2D menuImage;

	void OnGUI () {
		GUI.Box (new Rect (0,0,Screen.width,Screen.height), menuImage);

		if (GUI.Button (new Rect (Screen.width - 150, 20,107, 43), "")) {
			Application.LoadLevel(1);
		}

		if (GUI.Button (new Rect (Screen.width - 135, 70,78, 43), "")) {
			//Application.LoadLevel(1);
		}

		if (GUI.Button (new Rect (Screen.width - 155, 123,113, 43), "")) {
			Application.Quit();
		}
	}
}