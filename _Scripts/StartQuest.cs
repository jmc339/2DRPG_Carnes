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

public class StartQuest : MonoBehaviour {
	public int num; //quest number 
	private PlayerQuesting pq; //object of class 
	// Use this for initialization
	public bool _on, _off; 
	void Start () 
	{
		pq = FindObjectOfType<PlayerQuesting> (); 

	}
	
	// Update is called once per frame
	void Update () 	
	{



	}

	void OnTriggerEnter2D(Collider player) 
	{
		if(player.gameObject.name =="Player"&& !pq.adventure[num]) //if the gameobject that hits the collider is the player...execute code 
		{ 
			if(_on) //If the adventure is on 
			{
				if (!pq.adventure [num].gameObject.activeSelf) //check to see if it is already completed 
				{ 

					pq.adventure [num].gameObject.SetActive (true); //IF not set as the activce adventure 
					pq.adventure [num].Quest(); 


				} 
			} 
		}
	}
}