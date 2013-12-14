using UnityEngine;
using System.Collections;

public class BadGuy : MonoBehaviour {


	CharacterController controller;
	public float speed = 7f;
	public float gravity = 10f;
	public float jumpSpeed = 10f;
	private Vector2 moveDirection = Vector2.zero;
	bool hasDoubleJumped = false;
	public float doubleJumpSpeed = 2f;

	// Use this for initialization
	void Awake() {

	}
	void Start () {

		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

    	Vector2 forward = transform.TransformDirection(Vector2.right);
		controller.SimpleMove(forward * speed );

//		moveDirection.y -= gravity * Time.deltaTime;
//		moveDirection += Physics.gravity;
//		controller.Move(moveDirection * Time.deltaTime);
		
//		if (Input.GetKey(KeyCode.Space)) {
//			
//			moveDirection.y = jumpSpeed;
//			hasDoubleJumped = false;
//			
//			
//		}else if (!hasDoubleJumped  && !controller.isGrounded){
//			moveDirection.y = jumpSpeed*doubleJumpSpeed;
//			hasDoubleJumped = true;
//			
//		}
	
	}
}
