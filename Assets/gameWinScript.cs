using UnityEngine;
using System.Collections;

public class gameWinScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if(other.tag == "BadGuy"){
			Debug.Log( "- - - - - G A M E - - - -  W I N - - - - - - "); 
		}
	}
}
