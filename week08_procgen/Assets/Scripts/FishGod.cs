using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// USAGE: put this on an empty GameObject called "FishGod"
// INTENT: spawn and control the fish
public class FishGod : MonoBehaviour
{	
	// reference to our fish prefab
	public GameObject fishPrefab;
	
	// a list of all our spawned fish clones
	public List<GameObject> myFishList = new List<GameObject>();

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
			
			GameObject myNewFish = Instantiate( 
				fishPrefab, 
				spawnPos, 
				Quaternion.Euler(0, Random.Range(0,360), 0)
			);
			myFishList.Add( myNewFish ); // add fish clone to the list
			
			fishCounter += 1; // add 1 to variable
		}
		
	}


	void Update()
	{
		// press X to make all fish go to 0,0,0
		if (Input.GetKeyDown(KeyCode.X))
		{
			// use a for() loop to go through the list
			for (int i = 0; i < myFishList.Count; i++)
			{
				myFishList[i].GetComponent<Fish>().destination = Vector3.zero;
			}
		}
		
		// press K to randomly enlarge all the fish
		if (Input.GetKeyDown(KeyCode.K))
		{
			foreach (GameObject eachFish in myFishList)
			{
				eachFish.transform.localScale *= Random.Range(0.5f, 2f);
			}
		}
		
		// misc list operations you might find useful
		
		// remove items from the list?
		// myFishList.RemoveAt(5); // "remove item #5 from the list"
		
		// reset the list?
		// myFishList.Clear(); // Clear() will blank-out the list, set size=0
		
		
	}
	

}
