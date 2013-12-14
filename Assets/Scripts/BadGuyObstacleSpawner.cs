using UnityEngine;
using System.Collections;

public class BadGuyObstacleSpawner : MonoBehaviour {

	public GameObject[] obstacles;
	public GameObject bullet;
	public float bulletSpeed = 15f;
	private Vector2 moveDirection = Vector2.zero;

	float minThrowForce = 100f;
	float maxThrowForce = 200f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.K)) {

			int ori = Random.Range(0,obstacles.Length);

			GameObject obs = Instantiate(obstacles[ori], transform.position + Vector3.left * 1, transform.rotation) as GameObject;
		//	obs.rigidbody.AddForce(Vector3.up * Random.Range(minThrowForce,maxThrowForce  ));
			obs.transform.Translate(Vector3.up * 1f * Time.deltaTime);


		    }
		if (Input.GetKeyDown(KeyCode.L)) {
			

			GameObject obs = Instantiate(bullet, transform.position + Vector3.up * 1, transform.rotation) as GameObject;
			obs.rigidbody.velocity = new Vector2(- bulletSpeed, 0);
			
		}
		
		
		// CoinController coinnnn = clone.transform.Find("Coin").GetComponent<CoinController>();
	
	}
}
