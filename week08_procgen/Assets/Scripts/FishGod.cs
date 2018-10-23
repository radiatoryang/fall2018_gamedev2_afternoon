using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// USAGE: put this on an empty GameObject called "FishGod"
// INTENT: spawn and control the fish
public class FishGod : MonoBehaviour
{

	public GameObject fishPrefab;

	// spawn 100 fish in random positions
	void Start () {
		int fishCounter = 0;
		// keep planting grass as long as counter < 200!
		while (fishCounter < 100)
		{
			// this is where we actually instantiate grass
			Vector3 spawnPos = new Vector3(
				Random.Range(-5f, 5f), 
				0f, 
				Random.Range(-5f, 5f)
			);
			
			Instantiate( 
				fishPrefab, 
				spawnPos, 
				Quaternion.Euler(0, Random.Range(0,360), 0)
			);
			
			fishCounter += 1; // add 1 to variable
		}
		
	}
	

}
