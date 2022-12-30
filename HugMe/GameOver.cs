using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject loseCanvas;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }


    public void over()
    {
        loseCanvas.SetActive(true);
        //Time.timeScale = 0;
    }

    public void replay()
    {
        SceneManager.LoadScene(0);
    }
}
