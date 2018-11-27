using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// USAGE: put this on a different Sphere, assign variables
// PURPOSE: show a more complicated tween, using curves
public class CoroutineDemo : MonoBehaviour
{
	// assign in Inspector!
	public Transform sphere, cube;

	// "public" means I can edit the curve in Inspector
	public AnimationCurve myTweenCurve;

	// Use this for initialization
	void Start () {
		// DO NOT DO THIS:
		// MyFirstCoroutine(); // this will not work
		
		// INSTEAD, DO THIS:
		StartCoroutine( MyFirstCoroutine() );
	}
	
	// COROUTINE is a function that can last 1+ frame, and we can control how fast it runs
	// VERY IMPORTANT: every coroutine in Unity must return an IEnumerator
	IEnumerator MyFirstCoroutine()
	{
		Debug.Log("started the coroutine!");
		yield return 0; // wait for 1 frame, then continue
		Debug.Log("ok I waited 1 frame, now continuing...");
		yield return 1; // still just wait for 1 frame
		yield return null; // pause for another frame
		Debug.Log("ok waited 2 more frames, now continuing...");

		// to pause for 1 second, use WaitForSeconds
		yield return new WaitForSeconds(1f);
		Debug.Log("ok, finished waiting for 1 sec! now continuing...");

		// pause for as long as this coroutine is running
		yield return StartCoroutine( TweenCoroutine());
		
		// end of coroutine, it terminates itself
	}

	// tween our sphere towards our cube
	IEnumerator TweenCoroutine()
	{
		// setup variables before we start tweening
		float t = 0f; // "t" = time, like a counter variable
		Vector3 startPos = sphere.position;
		Vector3 endPos = cube.position;

		while (t < 1f) // as long as t < 100%, keep repeating this loop
		{
			// add tweening operation
			sphere.position = Vector3.LerpUnclamped(
				startPos, 
				endPos, 
				myTweenCurve.Evaluate(t)
			);
			t += Time.deltaTime; // deltaTime is the duration of frame in sec
			yield return 0; // pause for 1 frame, then continue
		}
		
	}
	
	
	
}
