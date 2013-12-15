using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour {

	void OnGUI () {
		// Make a background box
		if (GUI.Button (new Rect (Screen.width/2,Screen.height/2,150,100), "play")) {
			Application.LoadLevel(1);
		}
	}
}
