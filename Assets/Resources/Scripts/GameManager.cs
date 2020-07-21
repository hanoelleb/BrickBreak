using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int score;

    [SerializeField]
    Text scoreText;

    [SerializeField]
    GameOver GameOver;

    [SerializeField]
    GameObject gridPrefab;

    [SerializeField]
    GameObject currentGrid;

    private bool playerLost = false;

    // Start is called before the first frame update
    void Start()
    {
        currentGrid = GameObject.FindGameObjectWithTag("BrickGrid");
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
        if (currentGrid && currentGrid.transform.childCount == 0)
        {
            GameOver.Display(playerLost, score);
            GameOver.gameObject.SetActive(true);
        }
    }

    public void increaseScore(int num)
    {
        score += num;
    } 

    public void resetGame()
    {
        Destroy(currentGrid.gameObject);
        playerLost = false;
        score = 0;
        var newgame = Instantiate(gridPrefab);
        currentGrid = newgame;
        GameObject.FindGameObjectWithTag("Paddle").GetComponent<Paddle>().resetPaddle();
        GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>().resetBall();
    }

    public void setLose()
    {
        playerLost = true;
        GameOver.Display(playerLost, score);
        GameOver.gameObject.SetActive(true);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
