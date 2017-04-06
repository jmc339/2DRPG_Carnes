/*
James Carnes
ID: 2947845
<jmc339@zips.uakron.edu> 

2D RPG Game

Copyright 2017 
*/

//This controls the camera


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

	public GameObject followTarget; //sets a gameobject so that the camera will follow the player 
	
	private Vector3 targetPosition; //This is a 3 point vector i.e (x, y, z) note: a vector2 cannot be used even though this is a 2d game 
	
	public float moveSpeed; //sets the move speed for the camera 
	
	private static bool cameraAlready; //If there is already a camera in the world, destory any other camera....This is for changing levels 

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(transform.gameObject); //doesn't destroy camera on load 

		if(!cameraAlready) 
		{ //if camera does not exist in the game then do not destroy the player

			cameraAlready = true; 
			DontDestroyOnLoad(transform.gameObject); 
		} 
		else //if a camera does already exists, we need to destroy the extra camera that is created from moving between levels
		{ 
			Destroy(gameObject); 
		}
	}

		// Update is called once per frame
	void Update () 
	{
		//need to get x and y of target. Normally this is the Player
		targetPosition= new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, -10); //Here is the issue documented in the paper
		transform.position = Vector3.Lerp (transform.position, targetPosition, moveSpeed * Time.deltaTime); 
	}
}

