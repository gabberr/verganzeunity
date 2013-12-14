using UnityEngine;
using System.Collections;

public class BadGuyObstacleSpawner : MonoBehaviour {

	public GameObject[] obstacles;
	public GameObject bullet;
	public float bulletSpeed = 15f;
	private Vector2 moveDirection = Vector2.zero;

	GameObject player;
	
	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		print(player);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.K)) {

			int ori = Random.Range(0,obstacles.Length);

			Obstacle obs = Instantiate(obstacles[ori], transform.position - Vector3.left * 15, transform.rotation) as Obstacle;
		//	obs.player = player;
		//	obs.add
		//	obs.rigidbody.AddForce(Vector3.up * Random.Range(minThrowForce,maxThrowForce  ));

		//	iTween.MoveAdd(obs.transform.gameObject, iTween.Hash("ammount", transform.position, "easeType", "easeInOutExpo", "delay", .1));

		//	iTween.MoveAdd(obs.transform.gameObject, iTween.Hash("y", -2, "easeType", "easeInOutExpo", "delay", .2));

		//	obs.transform.Translate(Vector3.up * 1f * Time.deltaTime);


		    }
		if (Input.GetKeyDown(KeyCode.L)) {
			

			GameObject obs = Instantiate(bullet, transform.position + Vector3.up * 1, transform.rotation) as GameObject;
			obs.rigidbody.velocity = new Vector2(- bulletSpeed, 0);
			
		}
		
		
		// CoinController coinnnn = clone.transform.Find("Coin").GetComponent<CoinController>();
	
	}





}
