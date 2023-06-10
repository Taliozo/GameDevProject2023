using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropThroughInput : MonoBehaviour
{
    // Put in a way to check the current objects layer and replace the 6 in (6,8) with it 
    private int playerLayer;
    // Start is called before the first frame update
    void Start()
    {
        playerLayer = gameObject.layer;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    public void OnDropDown(){
        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit))
        {
            if(hit.collider.CompareTag("Platform"))
            {
                Debug.Log("Platform found");
                Physics.IgnoreLayerCollision(playerLayer, 8);
                StartCoroutine(enableColl());
            }
        }
    }

    IEnumerator enableColl()
    {
        yield return new WaitForSeconds(0.4f);
        Physics.IgnoreLayerCollision(playerLayer, 8, false);
        yield break;
    }

}
