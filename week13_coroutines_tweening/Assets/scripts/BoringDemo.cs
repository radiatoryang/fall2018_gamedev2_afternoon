using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// USAGE: put this on a Sphere, assign the Cube too
// INTENT: demo a boring way to move Sphere towards a Cube
public class BoringDemo : MonoBehaviour
{
	// assign in Inspector!
	public Transform sphere, cube;
	
	void Update ()
	{   // "boring" not-juicy way of moving things
		sphere.position = Vector3.MoveTowards(
			sphere.position, // start at sphere position
			cube.position, // go towards cube position
			0.2f // move at 0.2 meters per frame
		);
		// sphere will move at constant rate, stop abruptly
	}
}
