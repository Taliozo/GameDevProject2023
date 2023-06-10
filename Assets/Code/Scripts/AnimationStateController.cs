using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationStateController : MonoBehaviour
{
    private Animator animator;
    private Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMovement(InputAction.CallbackContext ctx)
    {
        //Debug.Log(ctx.ReadValue<Vector3>().x);
        if (ctx.ReadValue<Vector3>().x == 0)
        {
            animator.SetBool("isMoving", false);
        }
        else if (ctx.ReadValue<Vector3>().x != 0)
        {
            animator.SetBool("isMoving", true);
        }
    }

    public void OnJump(InputAction.CallbackContext ctx)
    {
        if (ctx.canceled)
        {
            animator.SetBool("Jump", false);
        }
        else
        {
            animator.SetBool("Jump", true);
        }
    }

    public void OnJab(InputAction.CallbackContext ctx)
    {
        if (ctx.canceled)
        {
            animator.SetBool("Jab", false);
        }
        else
        {
            animator.SetBool("Jab", true);
        }
    }
}
