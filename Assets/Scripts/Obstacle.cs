using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	float animateHeight;

//	[HideInInspector]
	public GameObject player;

	// Use this for initialization
	void Start () {
		player =  GameObject.Find("Player");

	}

	void AnimationUp() {
		animateHeight = Random.Range(1.5f,6f);
		iTween.MoveAdd(transform.gameObject, iTween.Hash("y", animateHeight,"time",0.5f, "easeType", "easeOutQuad", "onComplete","AnimationDown"));
	}

	void AnimationDown(){
		iTween.MoveAdd(transform.gameObject, iTween.Hash("y", -animateHeight,"time",0.5f, "easeType", "easeInQuad"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnBecameInvisible() {
	//	Debug.Log("Im invisible");
		enabled = false;
		Destroy(gameObject, 5);
	}


	void OnCollisionEnter(Collision collision) {
		if( collision.gameObject.name.Contains("Player"))	 {
			Debug.Log(gameObject + " collider with " + collision.gameObject);
		//	Destroy(gameObject);
		}

		Debug.Log(collision.gameObject.name);
	}
	void OnTriggerEnter(Collider other) {

		if (other.gameObject.name == "BadGuy")
			AnimationUp();

		if (other.gameObject.name == "Player") {

		//	print("Speed is:" + CharacterControll.speed);
			other.GetComponent<CharacterControll>().speed -=1;
		//	print("Speed is:" + CharacterControll.speed);
			StartCoroutine(backback());
		//	Invoke("backback", 1f);
		
		}


	}
	IEnumerator backback() {
		yield return new WaitForSeconds(1.0f);
		player.GetComponent<CharacterControll>().speed +=1;
		print("Speed is:" + player.GetComponent<CharacterControll>().speed);
	}




}
