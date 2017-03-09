/*
James Carnes
ID: 2947845
<jmc339@zips.uakron.edu> 

2D RPG Game
Copyright 2017 
*/


//Controls enemy health
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

	public int EnemyMaxHealth; 
	public int EnemyCurrentHealth;
	private PlayerLevelUp playerstats; 

	public int exp; 
	// Use this for initialization
	void Start () {
		EnemyCurrentHealth = EnemyMaxHealth; 
		playerstats = FindObjectOfType<PlayerLevelUp> (); 

	}

	// Update is called once per frame
	void Update () {

		if (EnemyCurrentHealth <= 0) {
			Destroy (gameObject); 
			playerstats.AddEXP (exp); 
		}
	}

	//Out of Update 

	public void HurtEnemy(int damageToEnemy)
	{
		EnemyCurrentHealth -= damageToEnemy; //sets player health to player health minus damage. 

	}
	public void SetmaxHealth()
	{
		EnemyCurrentHealth = EnemyMaxHealth; 
	}
}
