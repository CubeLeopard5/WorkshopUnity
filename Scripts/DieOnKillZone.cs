using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieOnKillZone : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Kill Zone"))
        {
            SceneManager.LoadScene("End Scene");
        }
    }
}
