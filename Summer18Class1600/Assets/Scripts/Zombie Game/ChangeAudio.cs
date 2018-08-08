using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAudio : MonoBehaviour {

	public AudioSource Intro;
	public AudioSource Loop;
	private bool startedLoop;

	private void Start()
	{
		Intro.Play();
		Loop.Stop();
	}

	void FixedUpdate()
	{
		if (!Intro.isPlaying && !startedLoop)
		{
			Loop.Play();
			startedLoop = true;
		}
	}
}
