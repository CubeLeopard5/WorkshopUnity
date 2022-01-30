using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveEnnemy : MonoBehaviour
{
    public Transform pos1, pos2;
    public float speed;
    public Transform startPos;
    private Vector3 nextPos;
    private Animator animator;
    void Start()
    {
        nextPos = startPos.position;
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 EnnemyScale = transform.localScale;
        if (transform.position == pos1.position)
        {
            nextPos = pos2.position;
            EnnemyScale.x = -5;
        }
        if (transform.position == pos2.position)
        {
            nextPos = pos1.position;
            EnnemyScale.x = 5;
        }
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
        transform.localScale = EnnemyScale;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("End Scene");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
    }
}
