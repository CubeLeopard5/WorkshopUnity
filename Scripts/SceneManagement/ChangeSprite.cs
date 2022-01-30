using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Sprite curSprite;
    public Sprite newSprite;
    private int ch = 0;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        curSprite = spriteRenderer.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a") && ch == 0)
        {
            chSprite(newSprite);
            ch = 1;
        }
        else if (Input.GetKeyDown("a") && ch == 1)
        {
            chSprite(curSprite);
            ch = 0;
        }
    }

    void chSprite(Sprite a)
    {
        spriteRenderer.sprite = a;
    }
}
