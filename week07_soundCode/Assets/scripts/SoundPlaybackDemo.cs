using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// usage: put this script on your AudioSource
// intent: demonstrate different use cases for playing sounds in games
public class SoundPlaybackDemo : MonoBehaviour
{

	AudioSource myAudio;
	public AudioClip anotherClip;

	void Start ()
	{ // cache reference to AudioSource component
		myAudio = GetComponent<AudioSource>();
	}
	
	void Update () {
		// simplest example of sound playback:
		// when we press SPACE, play the sound
		if (Input.GetKeyDown(KeyCode.Space))
		{
			myAudio.Play(); // play the sound from the AudioSource
		}
		
		// another example: play many sounds, overlapping, uninterruptable?
		// really good for fast events / impact / gunshots / etc
		if (Input.GetKeyDown(KeyCode.B))
		{
			myAudio.PlayOneShot( myAudio.clip );
		}
		
		// more complex example: play a sound as long as we're holding down a button
		if (Input.GetKey(KeyCode.S))
		{
			// Play() will RESET THE SOUND IF ALREADY PLAYING
			// myAudio.Play();

			// new: only play the sound if it's not already playing
			if (myAudio.isPlaying == false)
			{
				myAudio.Play();
			}
		}
		else
		{   // stop the sound if not holding [S]
			myAudio.Stop(); // there's also Pause() too!
			// this breaks the earlier PlayOneShot example though!
		}
	}
}
