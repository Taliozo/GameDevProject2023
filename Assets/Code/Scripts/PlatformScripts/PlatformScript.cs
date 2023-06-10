using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(BoxCollider))]
public class PlatformScript : MonoBehaviour
{
    [SerializeField] private Vector3 entryDirection = Vector3.up;
    [SerializeField] private bool localDirection = false;
    [SerializeField] private float triggerSizeX = 1.2f;
    [SerializeField] private float triggerSizeY = 2f;
    [SerializeField] private float triggerSizeZ = 1f;
    private new BoxCollider collider = null;

    private BoxCollider collisionCheckTrigger = null;

    private void Awake()
    {
        collider = GetComponent<BoxCollider>();
        //collider.isTrigger = true;

        collisionCheckTrigger = gameObject.AddComponent<BoxCollider>();
        collisionCheckTrigger.size = new Vector3(
            triggerSizeX,
            triggerSizeY,
            triggerSizeZ
            );
        // Hard coding the trigger size instead
        //collisionCheckTrigger.size = new Vector3(
        //    collider.size.x * triggerScale.x,
        //    collider.size.y * triggerScale.y,
        //    collider.size.z * triggerScale.z
        //   );

        collisionCheckTrigger.center = new Vector3(0, 0.5f, 0);
        collisionCheckTrigger.isTrigger = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if (Physics.ComputePenetration(
            collisionCheckTrigger, transform.position, transform.rotation,
            other, other.transform.position, other.transform.rotation,
            out Vector3 collisionDirection, out float penetrationDepth
            ))
        {

            Vector3 direction;
            if (localDirection)
            {
                direction = transform.TransformDirection(entryDirection.normalized);
            }
            else
            {
                direction = entryDirection;
            }

            float dot = Vector3.Dot(direction, collisionDirection);
            // Opposite direction, passing is not allowed
            if (dot < 0)
            {
                Physics.IgnoreCollision(collider, other, false);
                //Debug.Log("Cheese Dot < 0 AMOOOOONGUS");
            }
            else // dot > 0 , passing is allowed
            {

                Physics.IgnoreCollision(collider, other, true);
                //Debug.Log("Cheese Dot > 0 CHEEESE");
            }
        }
    }


    // Show direction where is solid and is not
    private void OnDrawGizmosSelected()
    {
        // Keeps direction consistent to world space in case of rotations.
        Vector3 direction;
        if (localDirection)
        {
            direction = transform.TransformDirection(entryDirection.normalized);
        }
        else
        {
            direction = entryDirection;
        }

        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, entryDirection);

        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, -entryDirection);

    }

}
