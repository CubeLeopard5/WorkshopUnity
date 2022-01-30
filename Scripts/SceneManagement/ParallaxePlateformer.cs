using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ParallaxePlateformer : MonoBehaviour
{
    public Transform centerBg;
    public SpriteRenderer sprite;
    private float length;
    void Start()
    {
        length = sprite.bounds.size.x;
    }
    void Update()
    {
        if (transform.position.x >= centerBg.position.x + length)
            centerBg.position = new Vector2(transform.position.x + length, centerBg.position.y);
        else if (transform.position.x <= centerBg.position.x - length)
            centerBg.position = new Vector2(transform.position.x - length, centerBg.position.y);
    }
}
