using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public bool gameOver;
    int score;
    public Text scoreText;
    public GameObject player;

	// Use this for initialization
	void Start () {
        score = 0;
        gameOver = false;
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!gameOver)
        {
            score = Mathf.FloorToInt(player.transform.position.z);
            scoreText.text = score + " Points";
        }
	}

    public void GameOver()
    {
        gameOver = true;
    }
}
