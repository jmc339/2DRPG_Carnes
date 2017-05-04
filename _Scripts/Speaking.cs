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
using UnityEngine.UI;

public class Speaking : MonoBehaviour {
	private PlayerControl player; //Object of PlayerControl class 

	public bool on; //checking to see if the dialouge box is on
	public int line; //The line for what the npc/sign/object/etc will say
	public Text boxText; //This is the text for the Canvas 
	public string[] textoptions; //This holds the dialouge 
	public GameObject box; //This is the actual dialouge box, if you go into Unity, you can see this under Canvas 




	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerControl> (); 
	}
	
	// Update is called once per frame
	void Update () {
		if (on && Input.GetMouseButtonUp (1)) { //If the player right clicks the next line is shown 


			line = line + 1; //Just moves the line up one 

		}

		if (line >= textoptions.Length) {
			player.move = true; 
			box.SetActive (false);  // The text box is set to inactive 
			on = false; 
			line = 0;  //The line is reset to 0 so that we dont get null reference errors...can comment out to see 
		}


			boxText.text = textoptions [line]; //sets to the current line no matter the number so long as it isnt null 

		//if(line==null) //Will this always evaluate to true...
			//Debug.Log ("That Line is NULL! Please adjust 'line'"); 
	}
	public void popbox(string text) // "pops" the text..but not a true pop off of stack 
	{
		player.move = false; 
		on = true; 
		box.SetActive (true);
		boxText.text = text; 
	}
	public void popspeach()
	{ 
		on = true; 
		box.SetActive (true);

	}
	
}
