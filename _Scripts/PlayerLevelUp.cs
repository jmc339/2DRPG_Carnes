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

public class PlayerLevelUp : MonoBehaviour {

	private PlayerHealthManager thePlayerhealth; 
	public int levelcurrently; 

	public int[] Healthlevel;
	public int health; 
	public int attk; 
	public int def; 
	public int[] attklevel; 
	public int[] deflevel; 

	public int xpcurrently; 

	public int[] Levelup; 
	public int nextlevel; 

	// Use this for initialization
	void Start () {
		health = Healthlevel [1]; //these just make the levels one at the start of game 
		attk = attklevel [1]; 
		def = deflevel [1]; 

		thePlayerhealth = FindObjectOfType<PlayerHealthManager> (); //sets to object of class 
	}
	
	// Update is called once per frame
	void Update () {
		if (xpcurrently >= Levelup [levelcurrently]) {
			
			IncreaseLevel (); 

			//other.gameObject.GetComponent<PlayerHealthManager> (); 
			//player.playerCurrentHealth = player.playerMaxHealth; 
			//nextlevel = levelcurrently + 1;
		}

	 
			
		
	}
	public void AddEXP(int exp)
	{
		xpcurrently += exp;
	}

	public void IncreaseLevel() //This increases the players level
	{
		
		levelcurrently += 1; 
		health = Healthlevel [levelcurrently]; //This adds health when a player levels up
	
		thePlayerhealth.playerMaxHealth = health; //sets health to max health 

		thePlayerhealth.playerCurrentHealth += health - Healthlevel [levelcurrently - 1]; 
		attk = attklevel [levelcurrently];  //sets attac level

		def = deflevel [levelcurrently]; //same for defense level  
	}



}
