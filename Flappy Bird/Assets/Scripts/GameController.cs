using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    bool isEndGame = false;
    int gamePoint = 0;
    public TextMeshProUGUI pointText;
    public GameObject endGamePanel;
    public TextMeshProUGUI endGamePointText;
    public Button btnReset;


    void Start()
    {
        Time.timeScale = 0.0f;
    }

    // Update is called once per frame
    void Update() 
    {
        if (isEndGame) 
        {
           
        } else
        {
            if (Input.GetMouseButtonDown(0))
            {
                Time.timeScale = 1.0f;
            }
        }
        
    }

    public void getPoint()
    {
        gamePoint++;
        pointText.text = "Điểm: " + gamePoint;
    }

    public void EndGame()
    {
        isEndGame = true;
        Time.timeScale = 0.0f;
        endGamePanel.SetActive(true);
        endGamePointText.text = "Điểm của bạn: " + gamePoint;

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public bool isEnd()
    {
        return isEndGame;
    }
}
