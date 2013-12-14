

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterControll : MonoBehaviour {

	//jump and crouch variables
	CharacterController controller;
	public float speed = 7f;
	public float gravity = 10f;
	public float jumpSpeed = 3f;
	private Vector2 moveDirection = Vector2.zero;
	public float doubleJumpSpeed = 2f;
	public float crouchHeight = 1f;
	public float standHight = 2f;
	bool  isCrouched = false;

	//Tequila speed boost
	public float speedBoost = 1f;
	private int tequilaShots;
	public GUIText shots;
	bool speedBoosted = false;
	float speedTimer = 2f;


	//fields for determing the characters moving direction
	private float previousCharacterDistance;
	private float currentCharacterDistance;
	
	//fields for controlling the camera's zoom
	public float camZOOMFactor = 6f;
	
	//references to other game objects
	public GameObject badGuyReference;
	public Camera cameraReference;


	//game Start game Over


	
	void Start(){
		print (cameraReference.orthographicSize);
	}

	/*void FixedUpdate() {
		currentCharacterDistance = Vector3.Distance(transform.position, badGuyReference.transform.position);

	}*/


	void  Update (){
		print (cameraReference.orthographicSize);
		shots.guiText.text = "Tequila: " + tequilaShots;
		CharacterController controller = GetComponent<CharacterController>();

		Vector2 forward = transform.TransformDirection(Vector2.right);
		controller.SimpleMove(forward * speed);
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);

		if (Input.GetKeyDown(KeyCode.Space) && isCrouched == false && controller.isGrounded)
			{
				moveDirection.y = jumpSpeed;
						
			}
		if (Input.GetKeyDown (KeyCode.LeftControl)) {
					controller.center = new Vector2(0, 0);
					controller.height = crouchHeight;
					isCrouched = true;
				}
		if (Input.GetKeyUp (KeyCode.LeftControl) && isCrouched == true){
				controller.center = new Vector2(0, 0.5f);
			   	controller.height = standHight;
				isCrouched = false;
			}

		// collecting and using tequila shots
		Tequila ();



		/*previousCharacterDistance = Vector3.Distance(transform.position, badGuyReference.transform.position);
		
		if(currentCharacterDistance - previousCharacterDistance > 0){
			//the player is moving to the right direction
			if(currentCharacterDistance < 50f && currentCharacterDistance > 10f){
				cameraReference.orthographicSize = Mathf.Lerp(previousCharacterDistance, currentCharacterDistance, .01f);
			}
			//cameraReference.transform.transform.Translate(Vector3.forward * (currentCharacterDistance/camZOOMFactor) * Time.deltaTime);
			//Debug.Log("gets Closer! othographic size = " + cameraReference.orthographicSize);
		}else if(currentCharacterDistance - previousCharacterDistance < 0){
			//the player is moving to the left direction
			if(currentCharacterDistance < 50f && currentCharacterDistance > 10f){
				cameraReference.orthographicSize = Mathf.Lerp(currentCharacterDistance, previousCharacterDistance, .01f);
			}
			//cameraReference.orthographicSize = cameraReference.orthographicSize * (currentCharacterDistance/camZOOMFactor);
			//cameraReference.transform.transform.Translate(-Vector3.forward * (currentCharacterDistance/camZOOMFactor) * Time.deltaTime);
		}
*/
}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Collectable")
		{
			tequilaShots = tequilaShots + 1;
		}
	}



	void Tequila()
	{
		if (speedBoosted == true) {
			speedTimer -= Time.deltaTime;
			if(speedTimer <= 0){
				speedBoosted = false;
				speed = speed - speedBoost;
				speedTimer = 2f;
			}
		}
		if (Input.GetKeyDown (KeyCode.X) && speedBoosted == false) {
			
			if(tequilaShots > 0)
			{
				speedBoosted = true;
				speed = speed + speedBoost;
				tequilaShots = tequilaShots - 1;
			}
			
		}
	}

}





