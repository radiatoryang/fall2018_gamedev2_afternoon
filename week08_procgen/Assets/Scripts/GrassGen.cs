using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// USAGE: put this on an empty GameObject called "GrassManager"
// INTENT: this will plant a field of grass via instantiate
public class GrassGen : MonoBehaviour
{
	// the grass blade we're cloning; assign in Inspector!
	public GameObject grassPrefab;

	void Start ()
	{
		int grassCounter = 0;
		// keep planting grass as long as counter < 200!
		while (grassCounter < 1000)
		{
			// this is where we actually instantiate grass
			Vector3 spawnPos = new Vector3(
				Random.Range(-5f, 5f), 
				0f, 
				Random.Range(-5f, 5)
			);
			Instantiate( 
				grassPrefab, 
				spawnPos, 
				Quaternion.Euler(0, Random.Range(0,360), 0)
			);
			
			grassCounter += 1; // add 1 to variable
		}
	}
	
}
