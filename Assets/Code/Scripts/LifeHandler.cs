using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class LifeHandler : MonoBehaviour
{
    public TextMeshProUGUI playerLife;
    [SerializeField] private int lifeCount = 3;
    private string playerName = "";
    public static string WinnerName = "";
    // Start is called before the first frame update
    void Start()
    {
        

        if (gameObject.layer == 6)
        {
            playerName = "P1";
            playerLife = GameObject.Find("playerLives1").GetComponent<TextMeshProUGUI>();
            //playerPercent = percentList[0];
        }
        if (gameObject.layer == 7)
        {
            playerName = "P2";
            playerLife = GameObject.Find("playerLives2").GetComponent<TextMeshProUGUI>();
            //playerPercent = percentList[1];
        }
    }

    // Update is called once per frame
    void Update()
    {
        playerLife.text = playerName + " Lives: " + lifeCount;
    }

    public void DecreaseLifeCount()
    {
        lifeCount -= 1;
        playerLife.text = playerName + " Lives: " + lifeCount;


        if(lifeCount == 0)
        {

            if (playerName == "P1")
            {
                WinnerName = "P2";
            }
            if (playerName == "P2")
            {
                WinnerName = "P1";
            }
            Debug.Log("Game Over!");
            GameObject gameManager = GameObject.FindGameObjectWithTag("GameManager");
            gameManager.GetComponent<GameManager>().HandleGameOver();
        }
    }


}
