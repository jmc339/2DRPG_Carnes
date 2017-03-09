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

public class PlayerHealthManager : MonoBehaviour {

	public int playerMaxHealth; 
	public int playerCurrentHealth;
	// Use this for initialization
	void Start () {
		playerCurrentHealth = playerMaxHealth; 
	}
	
	// Update is called once per frame
	void Update () {

		if (playerCurrentHealth <= 0) {
			gameObject.SetActive (false); 
		}
	}

//Out of Update 

	public void HurtPlayer(int damageToPlayer)
	{
		playerCurrentHealth -= damageToPlayer; //sets player health to player health minus damage. 

	}
	public void SetmaxHealth()
	{
		playerCurrentHealth = playerMaxHealth; 
	}
}
