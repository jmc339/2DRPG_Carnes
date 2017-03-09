/*
James Carnes
ID: 2947845
<jmc339@zips.uakron.edu> 

2D RPG Game
Copyright 2017 
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlimeControl : MonoBehaviour {
	public float moveSpeed; 
	private Rigidbody2D slimeRigidBody; 

	private bool movement; 

	public float pausetime; 
	private float pausetimecounter; 
	public float timeformove; 
	private float timeforMovecounter; 

	private Vector3 moveDirection; 
	public float waitforreload; 
private bool reloading; 
	private GameObject thePlayer; 


	// Use this for initialization
	void Start () {
		slimeRigidBody = GetComponent<Rigidbody2D> (); 

		//pausetimecounter = pausetime;    Might be helpful to debug 
		//timeforMovecounter = timeformove; 
		pausetimecounter = Random.Range(pausetime *0.75f, pausetime*1.25f); 
		timeforMovecounter = Random.Range(timeformove *0.75f, timeformove*1.25f); 
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (movement) {
			timeforMovecounter -= Time.deltaTime; 
			slimeRigidBody.velocity = moveDirection; 
			if (timeforMovecounter < 0) {
				movement = false; 
				//pausetimecounter = pausetime; 
				pausetimecounter = Random.Range (pausetime * 0.75f, pausetime * 1.25f); 
			}

		} else {

			pausetimecounter -= Time.deltaTime;
			slimeRigidBody.velocity = Vector2.zero; 

			if (pausetimecounter < 0f) {				
				movement = true;
				//timeforMovecounter = timeformove; 
				timeforMovecounter = Random.Range (timeformove * 0.75f, timeformove * 1.25f); 
				moveDirection = new Vector3 (Random.Range (-1f, 1f) * moveSpeed, Random.Range (-1f, 1f) * moveSpeed, 0f); 
					
			}

		
		}

		if (reloading) {
			waitforreload -= Time.deltaTime; 
			if (waitforreload < 0) {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
				thePlayer.SetActive (true); 
			}

		}
	}

	//This is for enemy dam 
	void OnCollisionEnter2D(Collision2D other)
	{
		/*if(other.gameObject.name=="Player")
			{
				other.gameObject.SetActive(false); ----------> This was used to test game objects but could be fun if un commented as the player is instantly killed if touched by an enemy
			reloading = true; 
				thePlayer = other.gameObject; 

			}*/
	}

}
