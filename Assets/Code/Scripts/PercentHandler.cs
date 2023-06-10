using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using System.Linq;

public class PercentHandler : MonoBehaviour
{
    private int currentPercent = 0;
    private float currentKnockbackForce = 0;
    private bool inKnockback = false;
    private float knockbackTimer = 0.6f;
    [SerializeField] private CharacterController controller;
    Vector3 velocity;
    Movement movement;

    private TextMeshProUGUI playerPercent;
    private String playerName = string.Empty;
    // Layer 6 = Player1
    // Layer 7 = Player2

    // Start is called before the first frame update
    void Start()
    {
        movement = gameObject.GetComponent<Movement>();

        if (gameObject.layer == 6)
        {
            playerName = "P1";
            playerPercent = GameObject.Find("playerPercent").GetComponent<TextMeshProUGUI>();
            //playerPercent = percentList[0];
        }
        if (gameObject.layer == 7)
        {
            playerName = "P2";
            playerPercent = GameObject.Find("playerPercent2").GetComponent<TextMeshProUGUI>();
            //playerPercent = percentList[1];
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Updates the UI with the percent ( NEED TO MAKE IT SO BOTH PLAYERS IDK HOW)
        playerPercent.text = playerName + " percent: " + currentPercent.ToString();

        // Handle knockback
        if (inKnockback)
        {
            Vector3 velocity = new Vector3(currentKnockbackForce, Math.Abs(currentKnockbackForce) * 0.5f, 0f);
            controller.Move(velocity * Time.deltaTime);
            knockbackTimer -= Time.deltaTime;

            if (knockbackTimer < 0)
            {
                inKnockback = false;
                knockbackTimer = 0.6f;
            }
        }
    }

    public void AddPercent(int damage)
    {
        currentPercent += damage;
        Debug.Log(currentPercent);
    }

    public void ApplyKnockback(float knockback)
    {
        currentKnockbackForce = currentPercent * knockback;
        Debug.Log("Applied Knockback Force of: " + currentKnockbackForce);
        inKnockback = true;
    }

    public void SetPercent(int newPercent)
    {
        currentPercent = newPercent;
    }
}
