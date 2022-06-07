using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour {
    AudioSource audioSrc;
    //AudioSource audsr;
    public float volume = 0.5f;
    public float pan = 0;
    public bool loop = true;
    // Use this for initialization
    void Start()
    {
        //audioSrc = GetComponent<AudioSource>();
        //audioSrc.Play();
		audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
		if (trigger.playing == true) {
			audioSrc.Play ();
			trigger.playing = false;
		}
		if (trigger.ratactive == true) {
			audioSrc.Stop ();
		}
    }
}
