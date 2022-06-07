using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decaydisplay : MonoBehaviour {
	GameObject pb1;
	GameObject pb2;
	GameObject pb3;
	GameObject pb4;
	GameObject pb5;
	GameObject pb6;
	// Use this for initialization
	void Start () {
		pb1 = GameObject.Find ("pb1");
		pb2 = GameObject.Find ("pb2");
		pb3 = GameObject.Find ("pb3");
		pb4 = GameObject.Find ("pb4");
		pb5 = GameObject.Find ("pb5");
		pb6 = GameObject.Find ("pb6");
	}
	
	// Update is called once per frame
	void Update () {
		if (shoot.decay <= 0.66f) {
			pb1.GetComponent<SpriteRenderer> ().enabled = false;
			pb2.GetComponent<SpriteRenderer> ().enabled = false;
			pb3.GetComponent<SpriteRenderer> ().enabled = false;
			pb4.GetComponent<SpriteRenderer> ().enabled = false;
			pb5.GetComponent<SpriteRenderer> ().enabled = false;
			pb6.GetComponent<SpriteRenderer> ().enabled = false;
		}
		if (shoot.decay <= 0.55f) {
			pb1.GetComponent<SpriteRenderer> ().enabled = true;
			pb2.GetComponent<SpriteRenderer> ().enabled = false;
			pb3.GetComponent<SpriteRenderer> ().enabled = false;
			pb4.GetComponent<SpriteRenderer> ().enabled = false;
			pb5.GetComponent<SpriteRenderer> ().enabled = false;
			pb6.GetComponent<SpriteRenderer> ().enabled = false;
		}
		if (shoot.decay <= 0.44f) {
			pb1.GetComponent<SpriteRenderer> ().enabled = true;
			pb2.GetComponent<SpriteRenderer> ().enabled = true;
			pb3.GetComponent<SpriteRenderer> ().enabled = false;
			pb4.GetComponent<SpriteRenderer> ().enabled = false;
			pb5.GetComponent<SpriteRenderer> ().enabled = false;
			pb6.GetComponent<SpriteRenderer> ().enabled = false;
		}
		if (shoot.decay <= 0.33f) {
			pb1.GetComponent<SpriteRenderer> ().enabled = true;
			pb2.GetComponent<SpriteRenderer> ().enabled = true;
			pb3.GetComponent<SpriteRenderer> ().enabled = true;
			pb4.GetComponent<SpriteRenderer> ().enabled = false;
			pb5.GetComponent<SpriteRenderer> ().enabled = false;
			pb6.GetComponent<SpriteRenderer> ().enabled = false;
		}
		if (shoot.decay <= 0.22f) {
			pb1.GetComponent<SpriteRenderer> ().enabled = true;
			pb2.GetComponent<SpriteRenderer> ().enabled = true;
			pb3.GetComponent<SpriteRenderer> ().enabled = true;
			pb4.GetComponent<SpriteRenderer> ().enabled = true;
			pb5.GetComponent<SpriteRenderer> ().enabled = false;
			pb6.GetComponent<SpriteRenderer> ().enabled = false;
		}
		if (shoot.decay <= 0.11f) {
			pb1.GetComponent<SpriteRenderer> ().enabled = true;
			pb2.GetComponent<SpriteRenderer> ().enabled = true;
			pb3.GetComponent<SpriteRenderer> ().enabled = true;
			pb4.GetComponent<SpriteRenderer> ().enabled = true;
			pb5.GetComponent<SpriteRenderer> ().enabled = true;
			pb6.GetComponent<SpriteRenderer> ().enabled = false;
		}
		if (shoot.decay <= 0.0f) {
			pb1.GetComponent<SpriteRenderer> ().enabled = true;
			pb2.GetComponent<SpriteRenderer> ().enabled = true;
			pb3.GetComponent<SpriteRenderer> ().enabled = true;
			pb4.GetComponent<SpriteRenderer> ().enabled = true;
			pb5.GetComponent<SpriteRenderer> ().enabled = true;
			pb6.GetComponent<SpriteRenderer> ().enabled = true;
		}
	}
}
