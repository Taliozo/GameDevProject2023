using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockZ : MonoBehaviour
{
    [SerializeField] float zpos = -1.15f;
    private void Update()
    {
        if (gameObject.transform.position.z != zpos)
        {
            ResetZ();
        }
    }

    private void ResetZ()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, zpos);
        Debug.Log("RESET ZED");
    }
}