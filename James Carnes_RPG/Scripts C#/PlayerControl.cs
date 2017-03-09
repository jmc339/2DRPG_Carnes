/*
James Carnes
ID: 2947845
<jmc339@zips.uakron.edu> 

2D RPG Game
Copyright 2017 
*/

//This Script handles the players movement and is needed for the game to work properly 
//In-line comments will give more detail 

using System.Collections;
using System.Collections.Generic; 
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public float moveSpeed; //for player speed
	private float moveCopy; 
	public float moveModify; 
	private Animator anim; //this is for walking animations 
	private bool isMoving; //seeing if the player is moving or not
	public Vector2 LastMove; //Holds players last direction to keep him/her facing that way. 
	private Rigidbody2D playerRigidBody; 
	private static bool playerAlready; 
	private bool isAttacking; // sees if player is attacking
	public float AttackTime; 
	private float AttackTimeCounter; 
	private float movespeedcop; 


	public string startPoint; 
	        


	// initialization

	void Start () {
		anim = GetComponent<Animator> (); //setting animation 
		playerRigidBody = GetComponent<Rigidbody2D> (); //setting rigid body
		if (!playerAlready) { //if player does not exist in the game then do not destroy the player

			playerAlready = true; 
			DontDestroyOnLoad (transform.gameObject); 
		} else { //if a player does already exists, we need to destroy the extra player/character that is created from moving between levels
			Destroy (gameObject); 
	
		}
	}
	// Update is called once per frame
	void Update () {
		isMoving = false; //this is used so that player movement is always false until the if statment hits. 

		if (!isAttacking) {

			if (Input.GetKeyDown (KeyCode.LeftShift)) {
				movespeedcop = moveSpeed; 
				movespeedcop = movespeedcop + 2; 

			}



				if (Input.GetAxisRaw ("Horizontal") > 0.9f || Input.GetAxisRaw ("Horizontal") < -0.9f) { //Horizontal refers to moving left or right
				
					//transform.Translate (new Vector3 (Input.GetAxisRaw ("Horizontal") * moveSpeed * Time.deltaTime, 0f,0f)); 
				playerRigidBody.velocity = new Vector2 (Input.GetAxisRaw ("Horizontal") * moveCopy, playerRigidBody.velocity.y); //stops player from bouncing when colliders hit. comment this out and un comment line 33 to see differene. 

					isMoving = true; //if the if statment executes then ismoving is set to true otherwise it stays fasle. 
					LastMove = new Vector2 (Input.GetAxisRaw ("Horizontal"), 0f);
				}

				//up and down 
				if (Input.GetAxisRaw ("Vertical") > 0.9f || Input.GetAxisRaw ("Vertical") < -0.9f) {
				
					//transform.Translate (new Vector3 (0f, Input.GetAxisRaw ("Vertical") * moveSpeed * Time.deltaTime,0f));

					playerRigidBody.velocity = new Vector2 (playerRigidBody.velocity.x, Input.GetAxisRaw ("Vertical") * moveCopy);

					isMoving = true; 
					LastMove = new Vector2 (0F, Input.GetAxisRaw ("Vertical"));
				}
				if (Input.GetAxisRaw ("Horizontal") < 0.9f && Input.GetAxisRaw ("Horizontal") > -0.5f) {
					playerRigidBody.velocity = new Vector2 (0f, playerRigidBody.velocity.y);
				}

				if (Input.GetAxisRaw ("Vertical") < 0.9f && Input.GetAxisRaw ("Vertical") > -0.5f) {
					playerRigidBody.velocity = new Vector2 (playerRigidBody.velocity.x, 0f);
				}

				if (Input.GetKeyDown (KeyCode.J)) {
					AttackTimeCounter = AttackTime; 
					isAttacking = true; 
					playerRigidBody.velocity = Vector2.zero; 
					anim.SetBool ("isAttacking", true);
				}

			if (Mathf.Abs (Input.GetAxisRaw ("Horizontal")) > 0.9f && (Mathf.Abs (Input.GetAxisRaw ("Vertical")) > 0.9f)){			


				moveCopy = moveSpeed * moveModify; 
			}


			else 
			{
				moveCopy = moveSpeed; 
			}
			

		}
		 if (AttackTimeCounter > 0) {
			AttackTimeCounter -= Time.deltaTime; 
		}
		if (AttackTimeCounter <= 0) {
			isAttacking = false; 
			anim.SetBool ("isAttacking", false); 
		}

		//For animations 
		anim.SetFloat ("MoveX", Input.GetAxisRaw ("Horizontal"));
		anim.SetFloat ("MoveY", Input.GetAxisRaw ("Vertical"));
		anim.SetBool ("Moving", isMoving);
		anim.SetFloat("LastX", LastMove.x); 
		anim.SetFloat("LastY", LastMove.y);
	}
}
