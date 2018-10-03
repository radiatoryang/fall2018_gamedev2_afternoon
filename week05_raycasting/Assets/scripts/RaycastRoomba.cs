using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// usage: put this script on a Cylinder in a simple maze
// intent: make this cylinder ("Roomba") move around and navigate maze
public class RaycastRoomba : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		// STEP 1: define Ray
		// Vector3.forward = world's forward, like "east", never changes
		// transform.forward = this object's forward, changes w/ rotation
		Ray roombaRay = new Ray( transform.position, transform.forward);
		
		// STEP 2: define maximum raycast distance
		float maxRaycastDistance = 1f; // just a bit in front of roomba?
		
		// STEP 3: visualize the raycast
		Debug.DrawRay( roombaRay.origin, roombaRay.direction * maxRaycastDistance, Color.cyan);
		
		// STEP 4: shoooot the raycast!!!
		if (Physics.Raycast(roombaRay, maxRaycastDistance))
		{
			// if raycast is true = there's a wall in front of us
			// randomly turn left or right?
			int randomNumber = Random.Range(0, 100); // rand num from 0-100
			if (randomNumber < 50)
			{ // 50% chance of turning left?
				transform.Rotate(0f, -90f, 0f);
			}
			else
			{ // 50% chance of turning right
				transform.Rotate(0f, 90f, 0f);
			}
		}
		else
		{
			// if raycast is false = nothing in raycast's way
			// so go forward
			transform.Translate(0f, 0f, Time.deltaTime);
		}
	}
}
