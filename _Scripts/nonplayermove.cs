/*
James Carnes
ID: 2947845
<jmc339@zips.uakron.edu> 

2D RPG Game
Copyright 2017 
*/

//This script is for Non-Player movement or NPCs 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nonplayermove : MonoBehaviour {

	public Speaking speak;  				//Object of class 
	public NewBehaviourScript nbs; 			// Object of class 
	public bool notalking; 					//for seeing if the npc is talking
	public Collider2D area; 				//Only lets the npc move WITHIN this box area	
	private Rigidbody2D rigid; 				//The npcs rigid body
	private float movecount; 				//How long the npc will move for 
	private float waitforcount; 			//How long the Npc will wait until he/she/it(?) will move again
	private int walk; 						//how long it will walk	
	private Vector2 lowWalk, highWalk; 		//How high up and how low itll walk 


	public bool whilewalk, _area; //checks to see if walking...checks to see if in area 

	public float npcmove; 
	public float walking, wait;  //for walking and waiting time 



	// Use this for initialization
	void Start () {
		notalking = true; //The npc is walking 
		speak = FindObjectOfType<Speaking> (); //just setting object of class 	
		rigid = GetComponent<Rigidbody2D> (); // --------------
		lowWalk = area.bounds.min; //Sets lower bound 	
		highWalk = area.bounds.max; //Sets higher bound
		waitforcount = wait; //sets wait counter equal to wait time 
		movecount = walking;  //sets walk counter equal to walk time 	
		forwalking (); //calls function 	
		_area = true; 	//The area is ture 

	}
	
	// Update is called once per frame
	void Update () {
		if (!speak.on) {

			notalking = true; 


		}
		if (!notalking) {
			rigid.velocity = Vector2.zero; //sets ability to move to 0
			return; //skips remaining code 
		} 

		if (whilewalk) {

			movecount = movecount - Time.deltaTime; //just finding the move time 
				
		

		
		if (walk == 0) { //If walks in 0 direction....higher y direction 
				
			rigid.velocity = new Vector2 (0, npcmove);
			if(_area&&transform.position.y> highWalk.y)
				{ whilewalk = false; 
					waitforcount = wait;
				}
					
		}

		if (walk == 1) { //Same but for 1
			rigid.velocity = new Vector2 (npcmove, 0); 
				if(_area&&transform.position.x> highWalk.x)
				{ whilewalk = false; 
					waitforcount = wait;
				}
		}

		if (walk == 2) {
			rigid.velocity = new Vector2 (0, -npcmove); 
				if(_area&&transform.position.y> lowWalk.y)
				{ whilewalk = false; 
					waitforcount = wait;
				}
		}

		if (walk == 3) {
			rigid.velocity = new Vector2 (-npcmove, 0); 
				if(_area&&transform.position.x> lowWalk.x)
				{ whilewalk = false; 
					waitforcount = wait;
				}
		}


		if (movecount < 0) { // if the move count is less than 0, they stop walking and wait to walk agin 
			whilewalk = false; 
			waitforcount = wait; 
		}
	}



		else {
					rigid.velocity=Vector2.zero;  //The rigid body velocity is set to zero ....It stops 
			waitforcount = waitforcount - Time.deltaTime; //waits 
			if (waitforcount < 0) {
				forwalking (); //walks 
			}
		}

	}

	public void forwalking ()
	{
		walk = Random.Range (0, 4); //randomly picks a direction to go 
		whilewalk = true; 
		movecount = walking;



	}
	
}
