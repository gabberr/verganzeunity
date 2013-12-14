using UnityEngine;
using System.Collections;

public class GroundFactory : MonoBehaviour {

	public GroundPartScript[] groundParts;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GenerateNextGround(Vector3 previous) {
	//	groundFactory
		GroundPartScript ground = Instantiate(groundParts[0], previous + Vector3.right * 11f, transform.rotation) as GroundPartScript;

	
	}

}
