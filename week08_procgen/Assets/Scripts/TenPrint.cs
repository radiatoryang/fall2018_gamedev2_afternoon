using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// USAGE: put this script on an empty GameObject called "TenPrintManager"
// INTENT: generate a 10PRINT-like pattern via random instantiation
public class TenPrint : MonoBehaviour
{
	// an array of forward-slash / back-slash prefabs
	public Transform[] slashPrefabs;
	
	void Start () {
		// randomly instantiate a prefab from the array
		// and arrange everything into a grid
		
		// first, instantiate a vertical line of objects
		// int vCount=0 : declare a counter variable
		// vCount < 10 : checking the counter variable
		// vCount++ : increments the counter
		for (int vCount = 0; vCount < 10; vCount++)
		{
			for (int hCount = 0; hCount < 10; hCount++)
			{
				// generate position in grid
				Vector3 spawnPos = new Vector3(hCount * 5, vCount * 5, 0);

				// instantiate a random item from the array
				int randomIndex = Random.Range(0, slashPrefabs.Length);
				Transform newClone = (Transform)Instantiate(
					slashPrefabs[randomIndex],
					spawnPos,
					slashPrefabs[randomIndex].rotation
					);
				
				// once you have a reference to the clone,
				// you can do whatever you want with the clone
				
				// randomly scale 50-200%?
				newClone.localScale *= Random.Range(0.5f, 2f);
				// random color for each object?
				newClone.GetComponent<Renderer>().material.color = Random.ColorHSV();
			}
		}
	}
}
