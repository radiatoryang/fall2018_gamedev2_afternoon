using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// put this script anywhere
// this will manage a simple text game where
// you hold down SPACE to win
public class SimpleTextGame : MonoBehaviour
{

	public Text myTextDisplay; // assign in Inspector
	float myScore = 0f; 
	
	// Update is called once per frame
	void Update () {
		// hold down spacebar to get points
		if (Input.GetKey(KeyCode.Space))
		{
			// Time.deltaTime is the duration of a frame
			// 100 FPS? dT = 1/100th of a second
			// 60 FPS? dT = 1/60th of a second
			// 1 FPS? dT = 1 of a second
			myScore += Time.deltaTime;
			Debug.Log( "currentScore: " + myScore.ToString() );
			
			// print to Text UI
			myTextDisplay.text = "try to get exactly 10.0";
			myTextDisplay.text += "\n current score: " + myScore.ToString();
		}
		
		// cheat code: press [C] to cheat and get 10 exactly
		if (Input.GetKeyDown(KeyCode.C))
		{
			myScore = 10f;
			myTextDisplay.text = "YOU ARE THE BEST, YOU WIN\n current score: 10.0000";
		}
	}
}
