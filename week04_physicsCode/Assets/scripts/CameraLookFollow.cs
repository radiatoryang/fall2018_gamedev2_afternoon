using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this is a demo script from WEEK 03 Lab
// how to get a camera to look at a target
public class CameraLookFollow : MonoBehaviour
{

	public Transform target;
	
	// Update is called once per frame
	void Update () {
		// step 1: calculate vector from camera to target
		Vector3 vectorA = Camera.main.transform.position;
		Vector3 vectorB = target.position;
		Vector3 fromAtoB = vectorB - vectorA; // vector from A to B == B - A

		// step 2: set camera to match that vector
		Camera.main.transform.forward = fromAtoB;
	}

	// OnDrawGizmos runs only in the editor, and it lets you draw things to Scene view
	void OnDrawGizmos()
	{
		Gizmos.color = Color.yellow;
		
		// for debug purposes, what if we wanted to see the line from A to B?
		if (target != null)
		{
			Gizmos.DrawLine(Camera.main.transform.position, target.position);
		}

		// what if we wanted to draw a wireframe cube 1m^3 around the camera?
		Gizmos.DrawWireCube( Camera.main.transform.position, Vector3.one);
	}
}
