using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// put this script on your trigger
// and it will delete anything that goes inside it
public class TriggerDemo : MonoBehaviour {

	// important usage note:
	// for OnTriggerEnter, at least one GameObject needs a Rigidbody
	void OnTriggerEnter(Collider activator)
	{
		// Destroy( activator ); // this is wrong; will only delete Collider
		Destroy( activator.gameObject ); // will delete whole object
	}
	
}
