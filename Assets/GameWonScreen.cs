using UnityEngine;
using System.Collections;

public class GameWonScreen : MonoBehaviour {

	public Texture2D image;
	
	void OnGUI () {
		GUI.Box(new Rect (0, 50, Screen.width, Screen.height), image);
		StartCoroutine(MyMethod());
	}
	
	IEnumerator MyMethod() {
		yield return new WaitForSeconds(3);
		Application.LoadLevel(2);
	}
}
