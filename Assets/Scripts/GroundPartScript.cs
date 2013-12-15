using UnityEngine;
using System.Collections;

public class GroundPartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnBecameInvisible() {
		//	Debug.Log("Im invisible");
		enabled = false;
		Destroy(gameObject, 1);
	}
}
