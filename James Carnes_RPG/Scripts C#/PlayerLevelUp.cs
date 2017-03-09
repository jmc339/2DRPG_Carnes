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

	public int levelcurrently; 

	public int xpcurrently; 

	public int[] Levelup; 
	public int nextlevel; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (xpcurrently >= Levelup [levelcurrently]) {
			levelcurrently += 1; 
			//nextlevel = levelcurrently + 1;
		}

	 
			
		
	}
	public void AddEXP(int exp)
	{
		xpcurrently += exp;
	}
}
