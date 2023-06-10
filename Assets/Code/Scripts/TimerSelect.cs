using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerSelect : MonoBehaviour
{
    public static float timeChosen = 300;


    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            timeChosen = 300;
        }
        if (val == 1)
        {
            timeChosen = 180;
        }
        if (val == 2)
        {
            timeChosen = 90;
        }
    }
}
