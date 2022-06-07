using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hat : MonoBehaviour {
    SpriteRenderer sr;
	public static int hatcolor = 2;
    // Use this for initialization
    void Start () {
        sr = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.R))
        {
            if(hatcolor == 2)
            {
                sr.sprite = Resources.Load("Sprites/brownhat", typeof(Sprite)) as Sprite;
                hatcolor = 3;
            }
            else if(hatcolor==3)
            {
                sr.sprite = Resources.Load("Sprites/yellowhat", typeof(Sprite)) as Sprite;
                hatcolor = 1;
            }
            else if(hatcolor==1)
            {
                sr.sprite = Resources.Load("Sprites/pinkhat", typeof(Sprite)) as Sprite;
                hatcolor = 2;
            }
        }
    }
}
