using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour {
	public Texture2D menuImage;

	void OnGUI () {
		GUI.Box (new Rect (0, 50,Screen.width,Screen.height), menuImage);

		if (GUI.Button (new Rect (Screen.width - 150, 70,107, 43), "")) {
			Application.LoadLevel(1);
		}

		if (GUI.Button (new Rect (Screen.width - 135, 120,78, 43), "")) {
			//Application.LoadLevel(1);
		}

		if (GUI.Button (new Rect (Screen.width - 155, 173,113, 43), "")) {
			Application.Quit();
		}
	}
}
