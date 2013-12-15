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


		    }
		if (Input.GetKeyDown(KeyCode.L)) {
			

			GameObject obs = Instantiate(bullet, transform.position + Vector3.up * 1, transform.rotation) as GameObject;
			obs.rigidbody.velocity = new Vector2(- bulletSpeed, 0);
			
		}

	
	}





}
