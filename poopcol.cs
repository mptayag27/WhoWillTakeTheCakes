using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poopcol : MonoBehaviour {
    public static bool poopbag = false;
    public static bool poopbaker = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name=="baker")
        {
            guiMain.score -= 15;
			baker.lives -= 1;
            if(guiMain.score<=0)
            {
                guiMain.score = 0;
            }
            Destroy(gameObject);
            poopbaker = true;
        }
        if (collision.gameObject.name == "plasticbag(Clone)")
        {
            Destroy(gameObject);
            poopbag = true;
        }
		//Destroy(gameObject);
    }
}
