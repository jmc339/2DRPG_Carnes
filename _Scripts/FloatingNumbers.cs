/*
James Carnes
ID: 2947845
<jmc339@zips.uakron.edu> 

2D RPG Game
Copyright 2017 
*/


//This script is for floating damageNumbers.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FloatingNumbers : MonoBehaviour {
	public float moveSpeed; 
	public int damageNumber; 
	public Text displayNumber; 


	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		displayNumber.text = "" + damageNumber; //displays the amount of damage delt 
		transform.position = new Vector3 (transform.position.x, transform.position.y + (moveSpeed * Time.deltaTime), transform.position.z);  
		
	}
}
