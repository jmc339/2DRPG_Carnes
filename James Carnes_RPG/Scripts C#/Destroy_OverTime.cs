/*
James Carnes
ID: 2947845
<jmc339@zips.uakron.edu> 

2D RPG Game
Copyright 2017 
*/


//Destroys gameobject overtime
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_OverTime : MonoBehaviour {
	public float timeDestroy;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timeDestroy -= Time.deltaTime;
		if(timeDestroy <= 0)
		{
			Destroy (gameObject); 
		
	}
}
}