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
	public GameObject damageNumber;//The floating damage number 



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
					
		
	}
	void OnTriggerEnter2D(Collider2D other) //uses a 2d collider and once that is hit by a weapon then it removes health. 
	{
		if (other.gameObject.tag == "Enemy")
		{
			other.gameObject.GetComponent<EnemyHealthManager> ().HurtEnemy (damagetoEnemy); 
			Instantiate (damage_burst, Hitmark.transform.position, Hitmark.transform.rotation);
			
			
			//var clone = (GameObject) Instantiate (damageNumber, Hitmark.position, Quaternion.Euler (Vector3.zero));  //These may not be needed, keeping until determined that they aren't needed
			//clone.GetComponent<FloatingNumbers> ().damageNumber = damagetoEnemy; 
		
	}
	}
}
