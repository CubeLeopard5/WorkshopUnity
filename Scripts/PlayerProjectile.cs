using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerProjectile : MonoBehaviour
{
    public float speed = 100.0f;
    private Rigidbody2D rb;
    private float origin;
    public float distanceTir = 10;
    public MoveLeftRight scriptA;
    // Start is called before the first frame update
    void Start()
    {
        scriptA = GameObject.FindObjectOfType<MoveLeftRight>();
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed * scriptA.dir, 0);
        origin = rb.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.transform.position.x > (origin + distanceTir) || rb.transform.position.x < (origin - distanceTir))
        {
            Destroy(this.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("enemy"))
        {
            Destroy(this.gameObject);
            Destroy(col.gameObject);
        }
    }
}
