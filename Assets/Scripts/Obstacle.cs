using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnBecameInvisible() {
	//	Debug.Log("Im invisible");
		enabled = false;
		Destroy(gameObject);
	}


	void OnCollisionEnter(Collision collision) {
		if( collision.gameObject.name.Contains("Player"))	 {
			Debug.Log(gameObject + " collider with " + collision.gameObject);
			Destroy(gameObject);
		}
		//	Debug.Log("Booooooom");
	}
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.name == "Player")
			Debug.Log(other.gameObject);
		
	}


}
