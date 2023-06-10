using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CharacterSelect : MonoBehaviour
{
    public GameObject[] characters;
    public static int selectedCharacterP1 = 0;
    public static int selectedCharacterP2 = 0;

    public TextMeshProUGUI p1CharName;
    public TextMeshProUGUI p2CharName;


    public void NextCharacterP1()
    {
        characters[selectedCharacterP1].SetActive(false);
        selectedCharacterP1 = (selectedCharacterP1 + 1) % characters.Length;
        characters[selectedCharacterP1].SetActive(true);
        p1CharName.text = characters[selectedCharacterP1].name;
    }

    public void PreviousCharacterP1()
    {
        characters[selectedCharacterP1].SetActive(false);
        selectedCharacterP1--;
        Debug.Log("amongus check");
        if (selectedCharacterP1 < 0)
        {
            selectedCharacterP1 += characters.Length;
        }
        characters[selectedCharacterP1].SetActive(true);
        p1CharName.text = characters[selectedCharacterP1].name;

    }

    public void NextCharacterP2()
    {
        characters[selectedCharacterP2].SetActive(false);
        selectedCharacterP2 = (selectedCharacterP2 + 1) % characters.Length;
        characters[selectedCharacterP2].SetActive(true);
        p2CharName.text = characters[selectedCharacterP2].name;

    }

    public void PreviousCharacterP2()
    {
        characters[selectedCharacterP2].SetActive(false);
        selectedCharacterP2--;
        if (selectedCharacterP2 < 0)
        {
            selectedCharacterP2 += characters.Length;
        }
        characters[selectedCharacterP2].SetActive(true);
        p2CharName.text = characters[selectedCharacterP2].name;

    }

    public void StartGame()
    {
        Debug.Log(selectedCharacterP1);
        Debug.Log(selectedCharacterP2);
        //PlayerPrefs.SetInt("p1Char", selectedCharacterP1);
        //PlayerPrefs.SetInt("p2Char", selectedCharacterP2);
        //SceneManager.LoadScene("SampleScene");
    }
}
