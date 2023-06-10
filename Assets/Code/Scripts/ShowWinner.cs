using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowWinner : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI WinnerText;
    private string WinText;
    // Start is called before the first frame update
    void Start()
    {
        WinText = LifeHandler.WinnerName;

        if (WinText == "P1")
        {
            WinnerText.text = "Player 1 Wins";
        }
        if (WinText == "P2")
        {
            WinnerText.text = "Player 2 Wins";
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
