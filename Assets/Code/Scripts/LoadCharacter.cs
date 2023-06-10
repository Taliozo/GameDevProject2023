using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class LoadCharacter : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject[] charPrefabs;

    private PlayerInput player1;
    private PlayerInput player2;

    private TextMeshProUGUI player1Percent;
    private TextMeshProUGUI player2Percent;

    private TextMeshProUGUI player1Lives;
    private TextMeshProUGUI player2Lives;
    // Start is called before the first frame update
    void Start()
    {
        int p1Character = CharacterSelect.selectedCharacterP1;
        int p2Character = CharacterSelect.selectedCharacterP2;

        Transform spawnPoint1 = spawnPoints[0].transform;
        Transform spawnPoint2 = spawnPoints[1].transform;
        Debug.Log(spawnPoint1.position);
        Debug.Log(spawnPoint2.position);

        
        //player1Percent = GameObject.Find("playerPercent").GetComponent<TextMeshProUGUI>();
        //player1Lives = GameObject.Find("playerLives1").GetComponent<TextMeshProUGUI>();
        //player2Percent = GameObject.Find("playerPercent2").GetComponent<TextMeshProUGUI>();
        //player2Lives = GameObject.Find("playerLives2").GetComponent<TextMeshProUGUI>();

        // PLAYER 1
        GameObject prefabP1 = charPrefabs[p1Character];
        prefabP1.layer = 6;

        player1 = prefabP1.GetComponent<PlayerInput>();
        //player1.ActivateInput();
        //player1.SwitchCurrentActionMap("Player1Keyboard");

        //prefabP1.GetComponent<PlayerInput>().SwitchCurrentActionMap("Player1Keyboard");
        //string peepee = player1.currentActionMap.name;
        Debug.Log("Current action map p1 " + prefabP1.layer);
        GameObject cloneP1 = Instantiate(prefabP1, spawnPoint1.position, Quaternion.Euler(0, 180, 0) );
        cloneP1.GetComponent<PlayerInput>().enabled = true;
        cloneP1.GetComponent<PlayerInput>().SwitchCurrentActionMap("Player1Keyboard");
        Debug.Log("Current action map p1 part 2 " + cloneP1.layer);


        // PLAYER 2
        GameObject prefabP2 = charPrefabs[p2Character];
        prefabP2.layer = 7;

        //player2 = prefabP2.GetComponent<PlayerInput>();
        //player2.ActivateInput();
        //player2.SwitchCurrentActionMap("Player2Keyboard");

        //prefabP2.GetComponent<PlayerInput>().SwitchCurrentActionMap("Player2Keyboard");
        Debug.Log("Current action map p2 " + prefabP2.layer);
        GameObject cloneP2 = Instantiate(prefabP2, spawnPoint2.position, Quaternion.Euler(0, 180, 0) );
        cloneP2.GetComponent<PlayerInput>().enabled = true;
        cloneP2.GetComponent<PlayerInput>().SwitchCurrentActionMap("Player2Keyboard");
        Debug.Log("Current action map p2 part 2 " + cloneP2.layer);

    }


    // Update is called once per frame
    void Update()
    {
        
    }

}
