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
using UnityEngine.SceneManagement;

public class LoadNewArea : MonoBehaviour {

	public string levelToLoad;

	public string exitPoint;

	private PlayerControl player; 
	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerControl> (); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		if(other.gameObject.name =="Player") 
		{
			SceneManager.LoadScene(levelToLoad); //Loading scene
			player.startPoint = exitPoint; 
		}
			
	}
}
