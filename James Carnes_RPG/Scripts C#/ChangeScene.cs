/*
James Carnes
ID: 2947845
<jmc339@zips.uakron.edu> 

2D RPG Game
Copyright 2017 
*/


//changes scene
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {


	//public string sceneName = 1; 
		public float xPosition;
		public float yPosition;



	// Use this for initialization although at this stage, it is not needed. 
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision other) {
		
		if(other.collider.tag == "Player") { //if the object that collides is the player then it will start switching levels 
			
			other.transform.position = new Vector3(17.1f, -11.51f , 0f); // let x = any number; the reason xf is used is because it is a float...0f for z axis because it is 2d.
			
			SceneManager.LoadScene(1); //loads scene 1...This can be chnaged to any scene name but only one scene currently. 
		}
	}
}
