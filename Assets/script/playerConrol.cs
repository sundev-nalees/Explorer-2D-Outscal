using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerConrol : MonoBehaviour
{
    
    bool grounded = false;
    float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;
    public Transform groundCheck;

    public scoreController scoreController;
    


    public Animator animator;
    bool crouch = false;
    public float jump;
    
    public float speed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    private void Awake()
    {
        
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void pickUpKey() 
    {
        Debug.Log("player picked up the key");
        scoreController.IncreseScore(10);
    }
    private void Update()
    {
        //run
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Jump");

        playerMovementAnimation(horizontal,vertical);
        playerMovementControl(horizontal,vertical);
        //crouch
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            crouch = true;
        }
        else if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            crouch = false;
        }
        animator.SetBool("crouch", crouch);
        //jump
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        animator.SetBool("isGround", grounded);
        animator.SetFloat("verticalSpeed", rb.velocity.y);
       
    }

    private void playerMovementAnimation(float horizontal,float vertical)
    {
        //player run
        animator.SetFloat("Speed", Mathf.Abs(horizontal));
        Vector3 scale = transform.localScale;
        if (horizontal < 0)
        {
            scale.x = -1f * Mathf.Abs(scale.x);
            

        }
        else if (horizontal > 0)
        {
            scale.x = Mathf.Abs(scale.x);
           
        }
        transform.localScale = scale;
        //player jumb

        if (vertical > 0) 
        {
            animator.SetBool("Jump", true);
        }
        else 
        {
            animator.SetBool("Jump", false);
        }
    }
    private void playerMovementControl(float horizontal,float vertical) 
    {
        //player run
        Vector3 position = transform.position;
        position.x +=   horizontal * speed * Time.deltaTime;
        transform.position = position;
        soundManager.Instance.Play(Sounds.PlayerMovement);
        //player jump
        if (grounded && vertical > 0) 
        {
            grounded = false;
            rb.AddForce(new Vector2(0f, jump), ForceMode2D.Force);
        }

    }
   
}
        
