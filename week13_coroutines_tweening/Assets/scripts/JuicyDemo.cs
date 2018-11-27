using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// USAGE: put this on a sphere or wherever
// PURPOSE: show a more juicy tweening demo than BoringDemo.cs
public class JuicyDemo : MonoBehaviour
{
	// assign in Inspector!
	public Transform sphere, cube;
	
	void Update ()
	{	// move 10% of remaining distance, every frame
		sphere.position += (cube.position - sphere.position) * 0.1f;
	}
}
