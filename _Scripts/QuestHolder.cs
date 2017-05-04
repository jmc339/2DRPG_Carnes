/*
James Carnes
ID: 2947845
<jmc339@zips.uakron.edu> 

2D RPG Game
Copyright 2017 
*/
//This holds various types for the PlayerQuesting Script 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestHolder : MonoBehaviour {

	public int quest; //just an int to hold which quest 
	public PlayerQuesting pq; //sets an object of the PlayerQuesting class 
	public string qlstart, qlend; //QuestLog Start, Questlog end...just string of text to show when a quest starts or ends. 
	public bool enemy; //Sets the quest as a quest to kill an enemy 
	public string whotokill; //what enemy to kill 
	public int howmany; //How many enemies to kill	
	public int togo; //How many left to finish the quest? (howmany-counter) 
	private int counter; //counts how many killed 

	// Use this for initialization
	void Start () {
		//again not "needed" but needed for unity to not complain 
	}
	
	// Update is called once per frame
	void Update () {
		if (enemy) {
			if (pq.destroycreat == whotokill) { //If the creature destroyed is the one needed for the quest 
				pq.destroycreat = null; 
				counter = counter + 1; //adds one to kill count
				togo = togo - 1; //one less to go! 
			}
			if (togo >= counter) { //if the togo num is the same or even higher than what is needed, the adventure ends 
				End (); 
			}
		
		}
	}


	public void Quest()
	{
		pq._Adventure(qlstart); //shows start texts 
	}

	public void End()
	{
		pq.finishedquests [quest] = true; 
		gameObject.SetActive (false); //sets the active quest to false. 
		pq._Adventure(qlend); 

	}
	//
}
