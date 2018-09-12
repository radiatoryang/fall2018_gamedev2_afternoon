using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		// print Hello World to the Unity console, once
		Debug.Log("Hello World!");
	}
	
	// Update is called once per frame
	void Update () {
		// print Hello World every frame, forever
		Debug.Log("Hola Mundo!");
	}
}
