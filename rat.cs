using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rat : MonoBehaviour
{
    public static float rl = 10;
    public static bool sounddie = false;
    Animator anim;
    float time = 0.0f;
    float interval = 2.0f;
    float time2 = 0.0f;
    float interval2 = 0.02f;
	public static float ratlives = 10;
    public GameObject prefab = null;
    //GameObject bar;
    //GameObject mona;
	GameObject h1;
	GameObject h2;
	GameObject h3;
	GameObject h4;
	GameObject h5;
	GameObject h6;
	GameObject h7;
	GameObject h8;
	GameObject h9;
	GameObject h10;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        //bar = GameObject.Find("bar");
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
		h1 = GameObject.Find ("h1");
		h2 = GameObject.Find ("h2");
		h3 = GameObject.Find ("h3");
		h4 = GameObject.Find ("h4");
		h5 = GameObject.Find ("h5");
		h6 = GameObject.Find ("h6");
		h7 = GameObject.Find ("h7");
		h8 = GameObject.Find ("h8");
		h9 = GameObject.Find ("h9");
		h10 = GameObject.Find ("h10");
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger.ratactive == true)
        {
            time += Time.deltaTime;
            if (time > interval)
            {
                anim.SetBool("open", true);

                time2 += Time.deltaTime;
                if (time2 > interval2)
                {
                    anim.SetBool("open", false);
                    time2 = 0f;
                }

                time = 0f;
            }
        }
		if (ratlives == 10) 
		{
			h10.GetComponent<SpriteRenderer> ().enabled = true;
			h9.GetComponent<SpriteRenderer> ().enabled = true;
			h8.GetComponent<SpriteRenderer> ().enabled = true;
			h7.GetComponent<SpriteRenderer> ().enabled = true;
			h6.GetComponent<SpriteRenderer> ().enabled = true;
			h5.GetComponent<SpriteRenderer> ().enabled = true;
			h4.GetComponent<SpriteRenderer> ().enabled = true;
			h3.GetComponent<SpriteRenderer> ().enabled = true;
			h2.GetComponent<SpriteRenderer> ().enabled = true;
			h1.GetComponent<SpriteRenderer> ().enabled = true;
		}
		if (ratlives == 9) 
		{
			h10.GetComponent<SpriteRenderer> ().enabled = false;
			h9.GetComponent<SpriteRenderer> ().enabled = true;
			h8.GetComponent<SpriteRenderer> ().enabled = true;
			h7.GetComponent<SpriteRenderer> ().enabled = true;
			h6.GetComponent<SpriteRenderer> ().enabled = true;
			h5.GetComponent<SpriteRenderer> ().enabled = true;
			h4.GetComponent<SpriteRenderer> ().enabled = true;
			h3.GetComponent<SpriteRenderer> ().enabled = true;
			h2.GetComponent<SpriteRenderer> ().enabled = true;
			h1.GetComponent<SpriteRenderer> ().enabled = true;
		}
		if (ratlives == 8) 
		{
			h10.GetComponent<SpriteRenderer> ().enabled = false;
			h9.GetComponent<SpriteRenderer> ().enabled = false;
			h8.GetComponent<SpriteRenderer> ().enabled = true;
			h7.GetComponent<SpriteRenderer> ().enabled = true;
			h6.GetComponent<SpriteRenderer> ().enabled = true;
			h5.GetComponent<SpriteRenderer> ().enabled = true;
			h4.GetComponent<SpriteRenderer> ().enabled = true;
			h3.GetComponent<SpriteRenderer> ().enabled = true;
			h2.GetComponent<SpriteRenderer> ().enabled = true;
			h1.GetComponent<SpriteRenderer> ().enabled = true;
		}
		if (ratlives == 7) 
		{
			h10.GetComponent<SpriteRenderer> ().enabled = false;
			h9.GetComponent<SpriteRenderer> ().enabled = false;
			h8.GetComponent<SpriteRenderer> ().enabled = false;
			h7.GetComponent<SpriteRenderer> ().enabled = true;
			h6.GetComponent<SpriteRenderer> ().enabled = true;
			h5.GetComponent<SpriteRenderer> ().enabled = true;
			h4.GetComponent<SpriteRenderer> ().enabled = true;
			h3.GetComponent<SpriteRenderer> ().enabled = true;
			h2.GetComponent<SpriteRenderer> ().enabled = true;
			h1.GetComponent<SpriteRenderer> ().enabled = true;
		}
		if (ratlives == 6) 
		{
			h10.GetComponent<SpriteRenderer> ().enabled = false;
			h9.GetComponent<SpriteRenderer> ().enabled = false;
			h8.GetComponent<SpriteRenderer> ().enabled = false;
			h7.GetComponent<SpriteRenderer> ().enabled = false;
			h6.GetComponent<SpriteRenderer> ().enabled = true;
			h5.GetComponent<SpriteRenderer> ().enabled = true;
			h4.GetComponent<SpriteRenderer> ().enabled = true;
			h3.GetComponent<SpriteRenderer> ().enabled = true;
			h2.GetComponent<SpriteRenderer> ().enabled = true;
			h1.GetComponent<SpriteRenderer> ().enabled = true;
		}
		if (ratlives == 5) 
		{
			h10.GetComponent<SpriteRenderer> ().enabled = false;
			h9.GetComponent<SpriteRenderer> ().enabled = false;
			h8.GetComponent<SpriteRenderer> ().enabled = false;
			h7.GetComponent<SpriteRenderer> ().enabled = false;
			h6.GetComponent<SpriteRenderer> ().enabled = false;
			h5.GetComponent<SpriteRenderer> ().enabled = true;
			h4.GetComponent<SpriteRenderer> ().enabled = true;
			h3.GetComponent<SpriteRenderer> ().enabled = true;
			h2.GetComponent<SpriteRenderer> ().enabled = true;
			h1.GetComponent<SpriteRenderer> ().enabled = true;
		}
		if (ratlives == 4) 
		{
			h10.GetComponent<SpriteRenderer> ().enabled = false;
			h9.GetComponent<SpriteRenderer> ().enabled = false;
			h8.GetComponent<SpriteRenderer> ().enabled = false;
			h7.GetComponent<SpriteRenderer> ().enabled = false;
			h6.GetComponent<SpriteRenderer> ().enabled = false;
			h5.GetComponent<SpriteRenderer> ().enabled = false;
			h4.GetComponent<SpriteRenderer> ().enabled = true;
			h3.GetComponent<SpriteRenderer> ().enabled = true;
			h2.GetComponent<SpriteRenderer> ().enabled = true;
			h1.GetComponent<SpriteRenderer> ().enabled = true;
		}
		if (ratlives == 3) 
		{
			h10.GetComponent<SpriteRenderer> ().enabled = false;
			h9.GetComponent<SpriteRenderer> ().enabled = false;
			h8.GetComponent<SpriteRenderer> ().enabled = false;
			h7.GetComponent<SpriteRenderer> ().enabled = false;
			h6.GetComponent<SpriteRenderer> ().enabled = false;
			h5.GetComponent<SpriteRenderer> ().enabled = false;
			h4.GetComponent<SpriteRenderer> ().enabled = false;
			h3.GetComponent<SpriteRenderer> ().enabled = true;
			h2.GetComponent<SpriteRenderer> ().enabled = true;
			h1.GetComponent<SpriteRenderer> ().enabled = true;
		}
		if (ratlives == 2) 
		{
			h10.GetComponent<SpriteRenderer> ().enabled = false;
			h9.GetComponent<SpriteRenderer> ().enabled = false;
			h8.GetComponent<SpriteRenderer> ().enabled = false;
			h7.GetComponent<SpriteRenderer> ().enabled = false;
			h6.GetComponent<SpriteRenderer> ().enabled = false;
			h5.GetComponent<SpriteRenderer> ().enabled = false;
			h4.GetComponent<SpriteRenderer> ().enabled = false;
			h3.GetComponent<SpriteRenderer> ().enabled = false;
			h2.GetComponent<SpriteRenderer> ().enabled = true;
			h1.GetComponent<SpriteRenderer> ().enabled = true;
		}
		if (ratlives == 1) 
		{
			h10.GetComponent<SpriteRenderer> ().enabled = false;
			h9.GetComponent<SpriteRenderer> ().enabled = false;
			h8.GetComponent<SpriteRenderer> ().enabled = false;
			h7.GetComponent<SpriteRenderer> ().enabled = false;
			h6.GetComponent<SpriteRenderer> ().enabled = false;
			h5.GetComponent<SpriteRenderer> ().enabled = false;
			h4.GetComponent<SpriteRenderer> ().enabled = false;
			h3.GetComponent<SpriteRenderer> ().enabled = false;
			h2.GetComponent<SpriteRenderer> ().enabled = false;
			h1.GetComponent<SpriteRenderer> ().enabled = true;
		}
        if (ratlives == 0)
        {
            SceneManager.LoadScene("end");
			int bonus = Mathf.RoundToInt (guiMain.guiTime);
			guiMain.score += bonus;
            sounddie = true;
			h10.GetComponent<SpriteRenderer> ().enabled = false;
			h9.GetComponent<SpriteRenderer> ().enabled = false;
			h8.GetComponent<SpriteRenderer> ().enabled = false;
			h7.GetComponent<SpriteRenderer> ().enabled = false;
			h6.GetComponent<SpriteRenderer> ().enabled = false;
			h5.GetComponent<SpriteRenderer> ().enabled = false;
			h4.GetComponent<SpriteRenderer> ().enabled = false;
			h3.GetComponent<SpriteRenderer> ().enabled = false;
			h2.GetComponent<SpriteRenderer> ().enabled = false;
			h1.GetComponent<SpriteRenderer> ().enabled = false;
			//for (int i = 0; i < 10; i++) 
			//{
			//	"h" [i].GetComponent<SpriteRenderer> ().enabled = false;
			//}
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
		if (collision.gameObject.name == "plasticbag(Clone)") 
		{
			ratlives -= 1;
		}
    }
}
