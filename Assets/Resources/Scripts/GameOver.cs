using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    Text finalScore;

    [SerializeField]
    Text header;

    [SerializeField]
    Text message;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Display(bool lost, int score)
    {
        finalScore.text = "score: " + score;
        if (lost)
        {
            header.text = "oh no!";
            message.text = "you lost.";
        } else
        {
            header.text = "congratulations!";
            message.text = "you won!";
        }
    }
}
