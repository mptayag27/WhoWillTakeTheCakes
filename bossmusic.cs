using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossmusic : MonoBehaviour {
	AudioSource audioSrc;
	//AudioSource audsr;
	public float volume = 0.5f;
	public float pan = 0;
	public bool loop = true;
	// Use this for initialization
	void Start()
	{
		audioSrc = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update()
	{
		if (trigger.playing2 == true) {
			audioSrc.Play ();
			trigger.playing2 = false;
		}
		if (trigger.ratactive == false) {
			audioSrc.Stop ();
		}
	}
}
