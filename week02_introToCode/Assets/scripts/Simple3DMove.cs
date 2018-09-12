using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// put this script on a Cube
// hold down WASD to move the cube around
public class Simple3DMove : MonoBehaviour
{

	public float moveSpeed = 0.1f;

	// Update is called once per frame
	void Update () {
		// hold W to move forward
		if (Input.GetKey(KeyCode.W))
		{
			// move cube along Z axis, 1 meter per frame
			// transform.position += new Vector3(0, 0, 1f);
			
			// move cube forward, based on the way it's facing
			transform.Translate(0, 0, moveSpeed); // follow local Z, not global Z
		}
		
		// hold A to turn the cube
		if (Input.GetKey(KeyCode.A))
		{
			// turn the cube 5 deg counter-clockwise on Y-axis
			transform.eulerAngles += new Vector3(0, -5f, 0);
		}
		
		// hold D to turn the cube the other way
		if (Input.GetKey(KeyCode.D))
		{
			transform.Rotate(0, 5f, 0);
		}
	}
}
