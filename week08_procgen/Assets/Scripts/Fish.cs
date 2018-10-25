using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// USAGE: put this script on a cube called "Fish"
// INTENT: this fish will swim around randomly
public class Fish : MonoBehaviour
{

	public Vector3 destination;
	public float swimSpeed = 3f;
	
	void Update () {
		// always swim towards your destination
		transform.position = Vector3.MoveTowards(
			transform.position,
			destination,
			swimSpeed * Time.deltaTime
		);
		
		// debug: draw a line to their destination in Scene tab
		Debug.DrawLine( transform.position, destination, Color.yellow);
		
		// if we reach our destination, pick a new random destination
		if (Vector3.Distance(transform.position, destination) < 2f)
		{
			destination = new Vector3(
				Random.Range(-10f, 10f),
				Random.Range(-10f, 10f),
				Random.Range(-10f, 10f)
				);
		}

		// DON'T DO THIS
//		if (transform.position == destination)
		
		// always turn towards its destination
		transform.LookAt( destination );
		
		// another way to move the fish:
		// move forward AFTER you look at your destination
		// transform.Translate(0f, 0f, swimSpeed * Time.deltaTime);

	}
}
