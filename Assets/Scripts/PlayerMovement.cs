using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // controls the character's speed

    private Rigidbody2D rb; 
    private Vector2 movement;
    private Animator animator;
    //stores the player's rigidbody + direction (physics stuff) + animations
    // private cus only this script needs to access this info


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        // makes rigidbody + animator attached to the player!!
    }

    void Update()
    {
        movement = Vector2.zero; // resets movement when no key is pressed

        if (Input.GetKey(KeyCode.UpArrow))
        {
            movement.y = 1;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            movement.y = -1;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movement.x = -1;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            movement.x = 1;
        }

        //moves player up, down, left, right!

        movement = movement.normalized; //if you press 2 keys, you can also go diagonally! this keeps diagonal movement from going faster

        animator.SetFloat("Speed", movement.sqrMagnitude);
        //tells the Animator whether the bunny is moving or not by setting speed value
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movement * moveSpeed;
        //movement is direction from the arrow keys, moveSpeed is how fast you want it to go 
        //basically this line actually makes the bunny move!
    }
}

