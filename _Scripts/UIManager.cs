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

public class UIManager : MonoBehaviour {
	public Slider hpbar; 
	public Text HpText; 
	//public Slider Lvlbar; 
	public PlayerHealthManager playerHealthmanager; 
	private static bool UIExist; 

	private PlayerLevelUp Plu; 
	public Text lvltxt; 
//private PlayerLevelUp bar; 

	// Use this for initialization
	void Start () {
		if (!UIExist) { //if player does not exist in the game then do not destroy the player

			UIExist = true; 
			DontDestroyOnLoad (transform.gameObject); 
		} else { //if a player does already exists, we need to destroy the extra player/character that is created from moving between levels
			Destroy (gameObject); 

		}
		Plu = GetComponent<PlayerLevelUp> (); 
		
		
	}
	
	// Update is called once per frame
	void Update () {
		hpbar.maxValue = playerHealthmanager.playerMaxHealth;  
		hpbar.value = playerHealthmanager.playerCurrentHealth; 
		HpText.text = "Health Points: " + playerHealthmanager.playerCurrentHealth + "/" + playerHealthmanager.playerMaxHealth; //Just shows the amount of health a player has on screen 
		lvltxt.text = "Level: " + Plu.levelcurrently; //Shows the current level by the health bar 
                 


	}
}
