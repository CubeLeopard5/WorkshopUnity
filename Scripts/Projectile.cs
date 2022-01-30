using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Projectile : MonoBehaviour
{
    public float speed = 50.0f;
    public int dir = 1;
    private Rigidbody2D rb;
    private float origin;
    public float distanceTir = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed * dir, 0);
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
        if (col.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("End Scene");
        }
    }
}
