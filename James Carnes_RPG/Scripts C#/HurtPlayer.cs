﻿/*
James Carnes
ID: 2947845
<jmc339@zips.uakron.edu> 

2D RPG Game
Copyright 2017 
*/


//Similar to "HurtEnemy"
//This is used to hurt the player

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour {

	public int damageToPlayer; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.name=="Player") //IF what hits an enemy..or anything else that is given the enemy script, is the Player, health will be removed. 
			{
			other.gameObject.GetComponent<PlayerHealthManager> ().HurtPlayer (damageToPlayer); 
			

			}
	}
}
