// Converted from UnityScript to C# at http://www.M2H.nl/files/js_to_c.php - by Mike Hergaarden
// Do test the code! You usually need to change a few small bits.

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
	public float speedBoost = 3f;
	private int tequilaShots;
	public GUIText shots;
	bool speedBoosted = false;
	float speedTimer = 2f;
	float speedTimerMax = 0.5f;
	
	
	
	//game Start game Over
	
	
	
	void Start(){
		
		
	}
	
	
	void  Update (){
		
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
		if(Input.GetKeyUp (KeyCode.LeftControl) && isCrouched == true){
			controller.center = new Vector2(0, 0.5f);
			controller.height = standHight;
			isCrouched = false;
		}
		if (Input.GetKeyDown (KeyCode.X)) {
			
			if(tequilaShots > 0)
			{
				speedBoosted = true;
				speedTimer -= Time.deltaTime;
				
				
				
				speed = speed + 3f;
				tequilaShots = tequilaShots - 1;
				
				if(speedTimer <= 0)
				{
					speedBoosted = false;
					speed = speed - 3f;
				}
				
				
			}
			
			
			
		}
		
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Collectable")
		{
			tequilaShots = tequilaShots + 1;
		}
	}
	void Timer(){
		speedTimer -= Time.deltaTime;
	}
	
}





