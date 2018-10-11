using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// CHANGELOG:
// 11 October 2018 -- added BetterMouseLook  -RY
// - clamping vertical look, to prevent inverted controls / upside down controls
// - cursor lock, very important for WebGL first person games

// usage: put this on a Cube with Main Camera parented to it
// this lets you do mouse look
public class BetterMouseLook : MonoBehaviour
{
	public float lookSpeed = 100f;
	
	// BETTER MOUSE LOOK;
	// degrees for looking up / down; stored as a float so we can clamp it later
	float verticalLook = 0f;
	
	void Update () {
		// MOUSE LOOK!!!
		
		// getting mouse input
		float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * lookSpeed; // horizontal mouse movement
		float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * lookSpeed; // vertical mouse movement
		
		// rotate the camera based on mouse input
		// first, rotate body based on horizontal mouse movement
		transform.Rotate( 0f, mouseX, 0f); // yaw
		
		// BETTER MOUSE LOOK:
		// add mouse input to verticalLook, then clamp verticalLook
		verticalLook += -mouseY;
		verticalLook = Mathf.Clamp(verticalLook, -80f, 80f);
		
		// actually apply verticalLook to camera's rotation
		Camera.main.transform.localEulerAngles = new Vector3(
			verticalLook,
			0f,
			0f
		);
		
		// BETTER MOUSE LOOK:
		// lock and hide the mouse cursor, if they click their mouse
		if (Input.GetMouseButtonDown(0)) // 0 = left-click
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false; 
		}
		

	}

	
}