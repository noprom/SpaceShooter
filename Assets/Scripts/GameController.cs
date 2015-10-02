﻿using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject hazard;
	public Vector3 spawnValues;

	// Use this for initialization
	void Start () {
		SpawnWaves ();
	}

	void SpawnWaves() {
		Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
		Quaternion spawnRotation = Quaternion.identity;

		Instantiate (hazard, spawnPosition, spawnRotation);
	}


	
	// Update is called once per frame
	void Update () {
	
	}
}
