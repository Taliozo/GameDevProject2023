using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public Button theButton;
    [SerializeField] string theScene;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = theButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }


    void TaskOnClick()
    {
        SceneManager.LoadScene(theScene);

    }
}