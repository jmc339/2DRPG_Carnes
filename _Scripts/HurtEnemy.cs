/*
James Carnes
ID: 2947845
<jmc339@zips.uakron.edu> 

2D RPG Game
Copyright 2017 
*/


//This checks and deals damage to an enemy 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour {
	public int damagetoEnemy; 

	public GameObject damage_burst;

	public Transform Hitmark; 

	private int attackdam; 


	private PlayerLevelUp lvlup; 



	// Use this for initialization
	void Start () {
		lvlup = FindObjectOfType<PlayerLevelUp> (); 
	}
	
	// Update is called once per frame
	void Update () {
					
		
	}
	void OnTriggerEnter2D(Collider2D other) //uses a 2d collider and once that is hit by a weapon then it removes health. 
	{
		if (other.gameObject.tag == "Enemy")
		{
			attackdam = damagetoEnemy + lvlup.attk; 
			other.gameObject.GetComponent<EnemyHealthManager> ().HurtEnemy (attackdam); 
			Instantiate (damage_burst, Hitmark.transform.position, Hitmark.transform.rotation);
			

	}
	}
}
