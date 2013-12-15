using UnityEngine;
using System.Collections;

public class splashScreen : MonoBehaviour {

	public Texture2D logoImage;

	void OnGUI () {
		GUI.Box(new Rect (0, 50, Screen.width, Screen.height), logoImage);
		StartCoroutine(MyMethod());
	}

	IEnumerator MyMethod() {
		yield return new WaitForSeconds(3);
		Application.LoadLevel(2);
	}

}
