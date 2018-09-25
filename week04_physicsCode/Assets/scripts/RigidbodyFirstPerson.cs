using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// usage: put this on a Capsule with a Rigidbody
// this script does mouse look and WASD movement for a player
public class RigidbodyFirstPerson : MonoBehaviour
{

	public float moveSpeed = 0.5f;
	
	// this variable will remember input and pass it to physics
	Vector3 inputVector;
	
	// Update is called once per frame
	void Update () {
		// MOUSE LOOK!!!
		
		// getting mouse input
		// these are mouse "deltas"... delta = difference
		// these will be 0 when nothing is moving, this ISN'T mouse position
		float mouseX = Input.GetAxis("Mouse X"); // horizontal mouse movement
		float mouseY = Input.GetAxis("Mouse Y"); // vertical mouse movement
		
		// rotations: Pitch Yaw Roll
		// pitch = up/down rotation, X axis
		// yaw = left/right rotation, Y axis
		// roll = rolling motion, Z axis
		
		// rotate the camera based on mouse input
		// first, rotate body based on horizontal mouse movement
		transform.Rotate( 0f, mouseX, 0f); // yaw
		Camera.main.transform.Rotate( -mouseY, 0f, 0f);
		
		
		// WASD MOVEMENT
		// GetAxis usually returns a float between -1f and 1f
		// when you're not pressing anything, it returns ~0f
		float horizontal = Input.GetAxis("Horizontal"); // A/D, Left/Right
		float vertical = Input.GetAxis("Vertical"); // W/S, Up/Down, Forward
		
		// apply keyboard input to position
		// when you do movement via "transform", you are teleporting it
		// transform.position += transform.forward * vertical * moveSpeed; // forward
		// transform.position += transform.right * horizontal * moveSpeed; // strafe
		// this method has NO COLLISION DETECTION ^
		
		// so, let's do this the better way...
		inputVector = transform.forward * vertical; // forward
		inputVector += transform.right * horizontal; // strafe
	}

	// it runs every physics frame (a different framerate than input or rendering)
	// all your physics code should go in FixedUpdate
	void FixedUpdate()
	{
		// override object's velocity with desired inputVector direction
		GetComponent<Rigidbody>().velocity = inputVector * moveSpeed + Physics.gravity * 0.69f;
		
	}
	
}
