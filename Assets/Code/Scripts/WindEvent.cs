using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindEvent : MonoBehaviour
{
    public Vector3 windDirection;
    // Start is called before the first frame update
    void Start()
    {
        windDirection = Vector3.right;
    }

    public void ChangeWindDirection(int windNum)
    {
        if (windNum == 0)
        {
            windDirection = Vector3.right;
        }
        if (windNum == 1)
        {
            windDirection = Vector3.left;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object entered trigger ( wind zone ) ");
    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("Object is in wind zone");
        //Vector3 position= transform.position;
        //Vector3 targetPosition = other.transform.position;
        Vector3 direction = windDirection;
        direction.Normalize();
        int moveSpeed = 1;
        other.transform.position += direction * moveSpeed * Time.deltaTime;
    }
}
