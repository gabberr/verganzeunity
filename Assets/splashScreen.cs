using UnityEngine;
using System.Collections;

public class splashScreen : MonoBehaviour {

	public Texture2D logoImage;

	void OnGUI () {
		GUI.Box(new Rect (0, 0, Screen.width, Screen.height), logoImage);

		if (GUI.Button (new Rect (Screen.width/2,Screen.height/2,150,100), "ENTER")) {
			Application.LoadLevel(2);
		}
	}
}
