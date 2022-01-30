using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Turret : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Rigidbody2D rb;
    private int a = 1;
    public int nbseconds;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (a == 1)
        {
            StartCoroutine(wait());
        }
    }

    public IEnumerator wait()
    {
        a = 0;
        shoot();
        yield return new WaitForSeconds(nbseconds);
        a = 1;
    }

    public void shoot()
    {
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = rb.transform.position;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("End Scene");
        }
    }
}
