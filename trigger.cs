using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour {
    public static bool ratactive = false;
	public static bool cameraactive = true;
	public static bool playing = true;
	public static bool playing2 = false;
	// Use this for initialization
	void Start () {
		playing = true;
		playing2 = false;
		cameraactive = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
		if (collision.gameObject.name == "baker") {
			ratactive = true;
			playing = false;
			playing2 = true;
			print ("pooper");
			guiMain.guiTime = 60.0f;
		}
		if (collision.gameObject.name == "camerastop") {
			cameraactive = false;

			print ("crap");
		}
    }
}
