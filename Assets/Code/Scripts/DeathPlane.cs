using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlane : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision) 
    {
        Debug.Log("game object entered trigger");
        collision.transform.position = new Vector3(0, 3, -1.150644f); // Warp player back to spawn point
        collision.GetComponent<PercentHandler>().SetPercent(0); // Reset % to 0
        collision.GetComponent<LifeHandler>().DecreaseLifeCount();
    }
}
