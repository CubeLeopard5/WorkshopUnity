using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MoveTopBellow : MonoBehaviour
{
    private Rigidbody2D rb;
    public float vitesse = 10;
    private Vector2 mov;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        mov.x = Input.GetAxisRaw("Horizontal");
        mov.y = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + mov * vitesse * Time.fixedDeltaTime);
    }
}
