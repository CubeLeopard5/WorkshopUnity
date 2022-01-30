using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftRight : MonoBehaviour
{
    private Rigidbody2D rb;
    public float vitesse = 10;
    private Animator animator;
    public int dir = 1;
    public string leftSide = "q";
    public string rightSide = "d";
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
        Vector3 PlayerScale = transform.localScale;
        if (Input.GetKey(leftSide))
        {
            dir = -1;
            rb.velocity -= new Vector2(vitesse, 0);
            if (rb.velocity.x < -vitesse) rb.velocity = new Vector2(-vitesse, rb.velocity.y);
            PlayerScale.x = -1;
        }
        else if (Input.GetKey(rightSide))
        {
            dir = 1;
            rb.velocity += new Vector2(vitesse, 0);
            if (rb.velocity.x > vitesse) rb.velocity = new Vector2(vitesse, rb.velocity.y);
            PlayerScale.x = 1;
        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x * 0, rb.velocity.y);
        }
        transform.localScale = PlayerScale;
    }
}
