using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOver : MonoBehaviour {

 
    public Text PlayerOneWinsText;
    public Text PlayerTwoWinsText;
    public Text WinText;
	// Use this for initialization
	void Start () {
    
        if (GameManager.playerOne.Won)
        {
            GameManager.PlayerOneWins++;
        } else if (GameManager.playerTwo.Won)
        {
            GameManager.PlayerTwoWins++;
        }
        print(GameManager.PlayerOneWins);
        print(GameManager.PlayerTwoWins);
    }
	
	// Update is called once per frame
	void Update () {
        if (GameManager.playerOne.Won)
        {
            WinText.text = "Player One Wins!";
        }else if (GameManager.playerTwo.Won)
        {
            WinText.text = "Player Two Wins!";
        }else
        {
            WinText.text = "";
        }
        PlayerOneWinsText.text = "Player One Wins: " + GameManager.PlayerOneWins;
        PlayerTwoWinsText.text = "Player Two Wins: " + GameManager.PlayerTwoWins;
    }
}
