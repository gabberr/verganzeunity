using UnityEngine;
using System.Collections;

public class GroundFactory : MonoBehaviour {

	public GroundPartScript[] groundParts;
	private int counter;
	private Vector3 lastPos;
	// Use this for initialization
	void Start () {
		counter = 3;
		lastPos = Vector3.zero;
		Generate();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GenerateNextGround(Vector3 previous) {
	//	groundFactory

		counter++;

		if (counter == 2) {
	 		
			Generate();

		}

//		int random = Random.Range(0, groundParts.Length);
//		GroundPartScript ground = Instantiate(groundParts[random], previous + Vector3.right * 14f, transform.rotation) as GroundPartScript;

	
	}
	private void Generate() {
		Vector3 position = Vector3.zero;
		for (int i=0; i<counter; i++) {


			//previous.y = 0;
			int random = Random.Range(0, groundParts.Length);

			position = lastPos + ( Vector3.right * 14f)*(i+1);


		//	lastPos =  lastPos + ( Vector3.right * 14f)*(i+1) ;


			GroundPartScript ground = Instantiate(groundParts[random],  position  , transform.rotation) as GroundPartScript;
		
		}
		counter=0;
		lastPos = position;
	}


}
