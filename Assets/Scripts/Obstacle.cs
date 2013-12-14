using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//iTween.moveTo(gameObject, {"z":-11.5, "time": 2, "transition":"easeInOutExpo", "onComplete":"Rotate1" });    


		iTween.MoveAdd(transform.gameObject, iTween.Hash("y", 2,"time",0.5f, "easeType", "easeOutQuad", "onComplete","Rotate1"));
	}
	
	void Rotate1(){
		iTween.MoveAdd(transform.gameObject, iTween.Hash("y", -2,"time",0.5f, "easeType", "easeInQuad"));
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
