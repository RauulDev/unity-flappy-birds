using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
    }

    [ContextMenu("Increase Score")]
    public void AddScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
