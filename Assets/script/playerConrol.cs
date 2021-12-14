using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerConrol : MonoBehaviour
{
    public Animator animator;
    bool crouch = false;
    public float verticalSpeed = 2f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        //run
        float speed = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Speed",Mathf.Abs(speed));
        
        Vector3 scale = transform.localScale;
        if (speed < 0) 
        {
            scale.x= -1f * Mathf.Abs(scale.x);

        }
        else if(speed>0)
        {
            scale.x = Mathf.Abs(scale.x);
        }
        transform.localScale = scale;
        
        //crouch
        if (Input.GetKeyDown(KeyCode.LeftControl)) 
        {
            crouch = true;
        }
        else if(Input.GetKeyUp(KeyCode.LeftControl))
        {
            crouch = false;
        }
        animator.SetBool("crouch", crouch);
        //jumb
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.AddForce (new Vector2(0,verticalSpeed));
            
        }
        animator.SetFloat("verticalSpeed", rb.velocity.y);
    }
}
        
