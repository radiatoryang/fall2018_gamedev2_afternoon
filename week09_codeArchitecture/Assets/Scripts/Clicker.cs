using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// USAGE: put this on an object with a Collider
// INTENT: you can click on this object to make it bigger
public class Clicker : MonoBehaviour {

	// OnMouseDown tells Unity to fire a raycast based on your mouse cursor
	// big flaw with OnMouseDown: doesn't tell you where you clicked / no RaycastHit
	void OnMouseDown()
	{
		// enlarge this object by 105%
		transform.localScale *= 1.05f;
		
		// access the static game manager and add a point
		ClickerManager.instance.myScore += 1;
		// notice: I don't need GetComponent or a public var
	}
	
}
