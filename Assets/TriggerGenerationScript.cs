using UnityEngine;
using System.Collections;

public class TriggerGenerationScript : MonoBehaviour {

	GameObject groundFactory;
	bool triggered;

	// Use this for initialization
	void Start () {
		groundFactory = GameObject.Find("GroundFactory");
		triggered=false;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other) { 
		Bounds bounds = transform.parent.renderer.bounds;
		Debug.Log(bounds);
		if(other.gameObject.name=="Player" && !triggered) {
			triggered=true;
			groundFactory.GetComponent<GroundFactory>().GenerateNextGround(transform.parent.position);
		}
	}
}
