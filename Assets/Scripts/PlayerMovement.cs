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
        // makes rigidbody + animator attached to the player!
    }

    void Update()
    {
        movement = Vector2.zero; // resets movement when no key is pressed

        if (Input.GetKey(KeyCode.UpArrow))
        {
            movement.y = 1; // to move up
            animator.SetInteger("Direction", 1); // to face up
        }

        //"direction" is the name of the parameter in the animator, and the numbers are the values that correspond to each direction
        //the animator will then play the corresponding animation based on the direction value



        if (Input.GetKey(KeyCode.DownArrow))
        {
            movement.y = -1; // to move down
            animator.SetInteger("Direction", 2); // to face down
        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movement.x = -1; //move left 
            animator.SetInteger("Direction", 3);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            movement.x = 1;//move right
            animator.SetInteger("Direction", 4);
        }

        //basically each number (1,2,3,4) corresponds to a direction in the animator so that depending on which key you press, the bunny will face that direction


        movement = movement.normalized; //if you press 2 keys, you can also go diagonally! this keeps diagonal movement from going faster

        animator.SetFloat("Speed", movement.sqrMagnitude);
        //"speed" is another name of the parameter in the animator
        //the animator will play the corresponding animation based on the speed value (e.g.if the speed is 0, the bunny will be idle, and if the speed is > than 0, the bunny will move)
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movement * moveSpeed;
        //movement is direction from the arrow keys, moveSpeed is how fast you want it to go 
        //basically this line actually makes the bunny move!
    }
}

