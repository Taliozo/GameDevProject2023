using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.layer == 6 || collision.gameObject.layer == 7)
        {
            collision.gameObject.transform.SetParent(transform);
            //collision.gameObject.AddComponent<Rigidbody>();
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.layer == 6 || collision.gameObject.layer == 7)
        {
            collision.gameObject.transform.SetParent(null);
            //Destroy(collision.gameObject.GetComponent<Rigidbody>());
        }
    }

}
