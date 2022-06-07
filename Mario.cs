//Attained through collaboration with classmates, not own code

//List of steps
//1. Create a trigger on the bottom of your object, this will dictate when your character can or can't jump
//2. Lock the z rotation in the RigidBody2D (this is in constraints)
//3. Edit the values in the Unity editor
//4. When you create the animation map set the name of the parameter in the unity editor

//For a basic 2D platformer I would reccomend using the following settings:

//In the script editor:
//Move Speed: 7
//Jump Force: 300

//In the RigidBody2D
//Mass: 0.5
//Gravity Scale: 3
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Mario : MonoBehaviour {

    public static Rigidbody2D rb;

    BoxCollider2D boxCol1;

    Animator anim;

    public float moveSpeed;

    public float jumpForce;

    public static float Xvelocity;

    public string runParameterName;

    public static bool isGrounded = true;
	
    public static bool pressed = false;

    bool isFacingRight = true;

    public float horizontal;
    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody2D>();

        boxCol1 = GetComponent<BoxCollider2D>();

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        Vector2 move = Vector2.zero;

	    move.x = Input.GetAxis ("Horizontal");
        horizontal = Input.GetAxis("Horizontal");
        Flip(horizontal);
        //anim.SetFloat(runParameterName, Mathf.Abs(horizontal));
        
        // Dictates movement to the right with the keyboard
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            Xvelocity = moveSpeed;
            pressed = true;
        }
        if ((Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D)) && Xvelocity != -7)
        {
            Xvelocity = 0;
            pressed = false;
            //rb.velocity = new Vector2(5f,0f);
        }
        //Dictates movement to the left with the keyboard
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            Xvelocity = -moveSpeed;
            pressed = true;
        }
        if ((Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A)) && Xvelocity != 7)
        {
            Xvelocity = 0;
            pressed = false;
        }
        //Dictates movement with the controller
        if (pressed == false)
        {
            Xvelocity = Input.GetAxis("Horizontal") * moveSpeed;
        }
        //Dictates jumping
        if (isGrounded == true && (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Joystick1Button0)))
        {
            print("k");
            isGrounded = false;
            rb.AddForce(new Vector2(0, jumpForce));
        }
        rb.velocity = new Vector2(Xvelocity, rb.velocity.y);
    }
    //Makes the sprite face the correct direction(only need right facing animations)
    private void Flip(float horizantal)
    {
        if (horizantal > 0 && !isFacingRight || horizantal < 0 && isFacingRight)
        {
            isFacingRight = !isFacingRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }
    //Decides if the player is grounded
    private void OnTriggerStay2D(Collider2D col)
    {
        isGrounded = true;
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        isGrounded = false;
    }
}
