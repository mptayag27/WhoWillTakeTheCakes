using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		guiMain.score++;
	}

	void OnCollisionEnter2D(Collision2D col) {  
		if (col.gameObject.name == "floor") {
			
		}
	}
}
