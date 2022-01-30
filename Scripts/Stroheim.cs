using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stroheim : MonoBehaviour
{
    public GameObject gb;
    private Transform stroheim;
    public int startPos = 30;
    public int endPos = 90;
    public int espaceX = 9;
    public int espaceY = 0;
    // Start is called before the first frame update
    void Start()
    {
        stroheim = gameObject.GetComponent<Transform>();
        stroheim.position = new Vector2(-100, -100);
    }

    // Update is called once per frame
    void Update()
    {
        if (gb.transform.position.x >= startPos && gb.transform.position.x <= endPos)
        {
            stroheim.position = new Vector2(gb.transform.position.x + espaceX, gb.transform.position.y + espaceY);
        }
        else
        {
            stroheim.position = new Vector2(-100, -100);
        }
    }
}
