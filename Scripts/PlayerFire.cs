using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Rigidbody2D rb;
    public MoveLeftRight scriptA;
    private float timeStart = 0;
    // Start is called before the first frame update
    void Start()
    {
        scriptA = GameObject.FindObjectOfType<MoveLeftRight>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P) && timeStart >= 1)
        {
            shoot();
            timeStart = 0;
        }
        timeStart += Time.deltaTime;
    }

    public void shoot()
    {
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = rb.transform.position + new Vector3(scriptA.dir, 0, 0);
    }
}