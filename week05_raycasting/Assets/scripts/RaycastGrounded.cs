using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// usage: put this script on a Cube
// intent: use this to see if the Cube is resting on ground or not
// ("grounded check")
public class RaycastGrounded : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		// STEP 1: define a "Ray"
		Ray myRay = new Ray( transform.position, Vector3.down);
		
		// STEP 2: set the raycast's maximum distance
		float maxRayDist = 0.6f; // a bit longer than half height
		
		// STEP 3: (optional) visualize the raycast in the Scene view
		Debug.DrawRay( myRay.origin, myRay.direction * maxRayDist, Color.yellow);
		
		// STEP 4: actually shoot the raycast
		// returns true or false, so wrap it in an if() statement
		if (Physics.Raycast(myRay, maxRayDist))
		{
			// if true: then it hit something! its resting on the floor!
			Debug.Log("the grounded raycast hit the floor!");
		}
		else
		{
			// if false: then NOT on the floor? rotate cube
			transform.Rotate(0f, 5f, 0f);
		}
	}
}
