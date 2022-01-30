using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string NameScene;

    public void go_game()
    {
        SceneManager.LoadScene(NameScene);
    }
}
