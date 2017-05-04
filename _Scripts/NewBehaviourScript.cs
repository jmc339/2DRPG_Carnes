/*
James Carnes
ID: 2947845
<jmc339@zips.uakron.edu> 

2D RPG Game
Copyright 2017 
*/
//This is used for Dialouge
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	public string WhatToSay; //What is to be displayed 	
	private Speaking speak; //object of speaking class 
	public string[] lines; //a string array to hold the various lines of dialouge 

	// Use this for initialization
	void Start () {
		speak = FindObjectOfType<Speaking> (); //justs sets as previously stated 

		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D _player) 
	{
		if (_player.gameObject.name == "Player") { //IF the object that presses 'right click' is the player then show dialouge 
			if (Input.GetMouseButtonUp (1)) {
				//speak.popbox (WhatToSay); 
				//

				if (!speak.on) { //If the dialouge box is not active 
					speak.textoptions = lines; 
					speak.line = 0;  //Starts at line 0 and moves to line n 
					speak.popspeach (); //"Pops" the line for dialouge...Not really a true pop. 
				}

				if(GetComponentInParent<nonplayermove>() != null) //IF the object the player clicks on is an npc, the npc cant walk... This allows for looking at objects without needing to give it a move speed 
					{
					GetComponentInParent<nonplayermove>().notalking = false; 
					} 



			}
		}
	}
}
