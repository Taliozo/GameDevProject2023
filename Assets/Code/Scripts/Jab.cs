using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jab : MonoBehaviour
{
    [SerializeField] private Transform hitboxCenter;
    [SerializeField] private float attackRange = 0.3f;
    [SerializeField] private LayerMask enemyLayer;
    [SerializeField] private int percent = 10;
    [SerializeField] private float knockback = 0.5f;
    private PlayerInput controls;
    private bool hitboxActive = false;
    private float hitboxTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.layer == 6)
        {
            enemyLayer = LayerMask.GetMask("Player2");
            controls = new PlayerInput();
        }
        else if (gameObject.layer == 7)
        {
            enemyLayer = LayerMask.GetMask("Player1");
            controls = new PlayerInput();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (hitboxActive && hitboxTimer > 0f)
        {
            Collider[] hurtbox = Physics.OverlapSphere(hitboxCenter.position, attackRange, enemyLayer); // Check if jab hitbox is overlapping the other players hurtbox
            foreach (Collider collision in hurtbox)
            {
                Debug.Log("Collision");

                if (gameObject.transform.eulerAngles.y == 90)
                {
                    collision.GetComponent<PercentHandler>().AddPercent(percent);
                    collision.GetComponent<PercentHandler>().ApplyKnockback(knockback);
                    hitboxActive = false;
                }
                else if (gameObject.transform.eulerAngles.y == 270)
                {
                    collision.GetComponent<PercentHandler>().AddPercent(percent);
                    collision.GetComponent<PercentHandler>().ApplyKnockback(-knockback);
                    hitboxActive = false;
                }
            }
        }

        hitboxTimer -= Time.deltaTime;
    }

    public void OnJab(InputAction.CallbackContext ctx)
    {
        hitboxActive = true;
        hitboxTimer = 3f;
    }

    void OnDrawGizmosSelected()
    {
        if (hitboxCenter == null)
            return;

        Gizmos.DrawWireSphere(hitboxCenter.position, attackRange);
    }
}
