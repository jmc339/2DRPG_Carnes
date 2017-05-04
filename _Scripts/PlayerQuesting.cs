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


public class PlayerQuesting : MonoBehaviour {

		public Speaking speak; //sets object of class 	
	public string destroycreat; //creature to get destroyed (normal rpg stuff) 


	public QuestHolder[] adventure; //sets an array to hold the various adventures (i.e quests) 
		public bool[] finishedquests; //this holds all finished quests to keep track of 




	// Use this for initialization
	void Start () {
		finishedquests = new bool[adventure.Length];  // sets finishedquests to a NEW boolean array with the length of the adventure array 
	}
	
	// Update is called once per frame
	void Update () {
		//not needed but is here because of Unity 
	}



	public void _Adventure(string questlog)
	{
		speak.textoptions= new string[1]; //This is for the openeing texts of adventure 
		speak.textoptions[0] = questlog; 

		speak.line = 0; 
		speak.popspeach (); 

	} 

}
