using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerConrol : MonoBehaviour
{
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
        //player jump
        if (vertical > 0) 
        {
            rb.AddForce(new Vector2(0f, jump), ForceMode2D.Force);
        }

    }
}
        
