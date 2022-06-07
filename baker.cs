using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class baker : MonoBehaviour {
	Animator anim;
	public static int lives = 3;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Mario.isGrounded == false)
        {
			anim.SetInteger("move", 2);
        }
		if (Mario.isGrounded == true) 
		{
			if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)) 
			{
				//print ("ll");
				anim.SetInteger ("move", 1);
			} 
			//if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D)||Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A))
			//{
			//	anim.SetInteger("move", 0);
			//}
			else 
			{
				anim.SetInteger ("move", 0);
			}
		}
		if (lives == 0) {
			SceneManager.LoadScene ("end");
		}
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name=="falldown")
        {
            SceneManager.LoadScene("end");
        }
		if(collision.gameObject.name=="toofar")
		{
			SceneManager.LoadScene("end");
		}
		if(collision.gameObject.name=="rat1")
		{
			lives =0;
		}
    }
}
