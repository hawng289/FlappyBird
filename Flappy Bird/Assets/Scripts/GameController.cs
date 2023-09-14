using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    bool isEndGame = false;
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update() 
    {
        if (isEndGame) 
        {
            if (Input.GetMouseButtonDown(0))

            {
              
                SceneManager.LoadScene(0);
            }
        } else
        {
            if (Input.GetMouseButtonDown(0))
            {
                Time.timeScale = 1.0f;
            }
        }
        
    }

    public void EndGame()
    {
        isEndGame = true;
        if (isEndGame)
        {
            Time.timeScale = 0.0f;
        }
    
    }
}
