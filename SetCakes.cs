using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCakes : MonoBehaviour {
    SpriteRenderer sr;
    int i;
	int cakecolor = 0;
	// Use this for initialization
	void Start () {
        sr = GetComponent<SpriteRenderer>();
        i = Random.Range(0, 3);
        SetColor();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void SetColor()
    {
        
        if (i ==0)
        {
            sr.sprite = Resources.Load("Sprites/yellowcupcake", typeof(Sprite)) as Sprite;
			cakecolor = 1;
        }
        if(i==1)
        {
            sr.sprite = Resources.Load("Sprites/pinkcupcake", typeof(Sprite)) as Sprite;
			cakecolor = 2;
        }
        if (i==2)
        {
            sr.sprite = Resources.Load("Sprites/browncupcake", typeof(Sprite)) as Sprite;
			cakecolor = 3;
        }
    }
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.name == "plasticbag(Clone)")
		{
			Destroy (collision.gameObject);
			Destroy(gameObject);
		}
		if (collision.gameObject.name == "baker")
		{
			if (cakecolor == Hat.hatcolor)
			{
				guiMain.score += 10;
				Destroy (gameObject);
				//print ("h" + "" + Hat.hatcolor);
				//print ("c" + "" + cakecolor);
			}
		}
	}

}
