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
		int random = Random.Range(0, groundParts.Length);
		GroundPartScript ground = Instantiate(groundParts[random], previous + Vector3.right * 11f, transform.rotation) as GroundPartScript;

	
	}

}
