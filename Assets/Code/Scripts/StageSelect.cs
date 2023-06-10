using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    public GameObject[] stageList;
    public string[] stageListNames;
    
    public int selectedStageNum = 0;

    public TextMeshProUGUI stageNameBox;

    public void NextStage()
    {
        stageList[selectedStageNum].SetActive(false);
        selectedStageNum = (selectedStageNum + 1) % stageList.Length;
        stageList[selectedStageNum].SetActive(true);
        stageNameBox.text = stageList[selectedStageNum].name;
    }

    public void PreviousStage()
    {
        stageList[selectedStageNum].SetActive(false);
        selectedStageNum--;
        Debug.Log("amongus check");
        if (selectedStageNum < 0)
        {
            selectedStageNum += stageList.Length;
        }
        stageList[selectedStageNum].SetActive(true);
        stageNameBox.text = stageList[selectedStageNum].name;
    }

    public void LoadSelectedStage()
    {
        Debug.Log(stageListNames[selectedStageNum]);
        SceneManager.LoadScene(stageListNames[selectedStageNum]);
    }

}
