using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject plasticbag = null;
    private bool shot = false;
    public static float decay;
	public static bool woosh;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Reload();
        if (Input.GetKeyDown(KeyCode.Space) && !shot)
        {
            decay = 0.66f;
            shot = true;
			woosh = true;
            GameObject obj = (GameObject)Instantiate(plasticbag, transform.position, transform.rotation);
            obj.GetComponent<Rigidbody2D>().velocity = new Vector2(17f, 0f);
        }

    }
    private void Reload()
    {
        if (shot && decay > 0)
        {
            decay -= Time.deltaTime;
        }
        if (decay < 0)
        {
            decay = 0;
            shot = false;
        }
    }
}