using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public GameObject player;
    public float jump = 10;
    public string key = "space";
    public string ground = "Ground";
    private bool isGrounded = false;
    private Rigidbody2D rb;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key) && isGrounded == true)
        {
            rb.velocity += new Vector2(0, jump);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag(ground))
        {
            isGrounded = true;
            player.transform.parent = col.gameObject.transform;
            animator.SetBool("isJump", false);
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag(ground ))
        {
            isGrounded = false;
            player.transform.parent = null;
            animator.SetBool("isJump", true);
        }
    }
}
