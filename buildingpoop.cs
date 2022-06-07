using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingpoop : MonoBehaviour {
	int i;
	// Use this for initialization
	void Start () {
		i = Random.Range (0, 2);
		if (i == 1) {
			gameObject.GetComponent<SpriteRenderer> ().enabled = false;
			gameObject.GetComponent<PolygonCollider2D> ().enabled = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
