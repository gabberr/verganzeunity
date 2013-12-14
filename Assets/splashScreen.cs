using UnityEngine;
using System.Collections;

public class splashScreen : MonoBehaviour {

	public Texture2D logoImage;

	void OnGUI () {
		// Make a background box
		if (GUI.Button (new Rect (Screen.width/2,Screen.height/2,150,100), logoImage)) {
			Application.LoadLevel(1);
		}
	}
}
