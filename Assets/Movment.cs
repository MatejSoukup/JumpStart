using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class Movment : MonoBehaviour
{
    private float horizontal;
    public Rigidbody2D rb;
    public Transform Ground;
    public LayerMask GroundLayer;
    public float speed = 1;
    public float jumpforce = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            rb.velocity = new Vector2(horizontal * speed, rb.velocity.y + jumpforce);
        }

    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        
    }
    private bool isGrounded()
    {
        return Physics2D.OverlapCircle(Ground.position, 0.3f, GroundLayer);
    }
  
}
