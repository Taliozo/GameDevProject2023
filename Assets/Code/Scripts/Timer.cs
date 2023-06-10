using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI eventName;
    [SerializeField] public float timeNum = 300;
    [SerializeField] GameObject[] weatherEvents; 
    public bool timerIsRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        timeNum = TimerSelect.timeChosen;
        timerIsRunning = true;
        timerText.text = timeNum.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeNum > 0)
            {
                timeNum -= Time.deltaTime;
                DisplayTime(timeNum);
            }
            else
            {
                //Debug.Log("cheese");
                timeNum = 0;
                timerIsRunning = false;

                GameObject gameManager = GameObject.FindGameObjectWithTag("GameManager");
                gameManager.GetComponent<GameManager>().HandleGameOver();

            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        weatherEvent(seconds);
        //Debug.Log(seconds);
    }

    void weatherEvent(float timeInSeconds)
    {
        if (timeInSeconds == 30)
        {
            Random.InitState(System.DateTime.Now.Second);
            int randnum = Random.Range(0, 1);
            //Debug.Log("WEATHER EVENT");
            eventName.text = "WIND EVENT!";
            StartCoroutine(startWind(randnum));
        }
    }


    IEnumerator startWind(int randomNum)
    {
        if (randomNum == 1)
        {
            weatherEvents[0].transform.rotation = Quaternion.Euler(0, -180, 0);
            weatherEvents[0].GetComponent<WindEvent>().ChangeWindDirection(1);
            Debug.Log("Rotation yes");
            Debug.Log(randomNum);
        }
        weatherEvents[0].SetActive(true);
        yield return null;

        yield return new WaitForSeconds(20);
        weatherEvents[0].SetActive(false);
        weatherEvents[0].transform.rotation = Quaternion.Euler(0, 0, 0);
        weatherEvents[0].GetComponent<WindEvent>().ChangeWindDirection(0);
        eventName.text = "";
    }
}
