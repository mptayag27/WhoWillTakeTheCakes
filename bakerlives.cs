using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bakerlives : MonoBehaviour {
	GameObject l1;
	GameObject l2;
	GameObject l3;
	// Use this for initialization
	void Start () {
		l1 = GameObject.Find ("l1");
		l2 = GameObject.Find ("l2");
		l3 = GameObject.Find ("l3");
	}
	
	// Update is called once per frame
	void Update () {
		if (baker.lives == 3) {
			l1.GetComponent<SpriteRenderer> ().enabled = true;
			l2.GetComponent<SpriteRenderer> ().enabled = true;
			l3.GetComponent<SpriteRenderer> ().enabled = true;
		}
		if (baker.lives == 2) {
			l1.GetComponent<SpriteRenderer> ().enabled = true;
			l2.GetComponent<SpriteRenderer> ().enabled = true;
			l3.GetComponent<SpriteRenderer> ().enabled = false;
		}
		if (baker.lives == 1) {
			l1.GetComponent<SpriteRenderer> ().enabled = true;
			l2.GetComponent<SpriteRenderer> ().enabled = false;
			l3.GetComponent<SpriteRenderer> ().enabled = false;
		}
	}
}
