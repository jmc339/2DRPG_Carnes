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
//This checks player position when loading into new levels or scenes 

public class PlayerStartPoint : MonoBehaviour {

	private PlayerControl thePlayer; 
	private CameraControl theCamera; 

	public Vector2 FaceDirrection; 

	public string PointName; 

	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerControl> (); 

		if (thePlayer.startPoint == PointName) {



			thePlayer.transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z); 
			thePlayer.LastMove = FaceDirrection; 



			theCamera = FindObjectOfType<CameraControl> (); 
			theCamera.transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z); 
		}
		 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

