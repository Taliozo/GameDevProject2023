using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    private PlayerInput controls;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private bool doubleJumpAvailable;
    [SerializeField] private float playerSpeed = 2.0f;
    [SerializeField] private float jumpHeight = 1.0f;
    [SerializeField] private float gravityValue = -20f;

    [SerializeField] private float jumpBufferTimer = 0.1f;
    private float timeSinceJumpPress = 0f;
    private bool recoveryAvailable = true;

    private void Awake()
    {
        controls = new PlayerInput();
    }

    private void Start()
    {

    }

    void Update()
    {
        Physics.SyncTransforms(); // Switch to fixedUpdate instead of calling this
        // Reset state
        playerVelocity.z = 0;
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = gravityValue * Time.deltaTime;
            doubleJumpAvailable = false;
            gravityValue = -20;
            recoveryAvailable = true;
        }

        // Handle jump input/double jump
        timeSinceJumpPress = timeSinceJumpPress - Time.deltaTime;

        // Apply gravity and move player
        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }

    private void OnEnable()
    {
        //controls.Player1Keyboard.Enable();
        //controls.Player2Keyboard.Enable();
    }

    public void OnMovement(InputAction.CallbackContext ctx)
    {
        playerVelocity.x = ctx.ReadValue<Vector3>().x * playerSpeed;

        if(playerVelocity.x > 0)
        {
            gameObject.transform.eulerAngles = new Vector3(0, 90, 0);
        }

        if(playerVelocity.x < 0)
        {
            gameObject.transform.eulerAngles = new Vector3(0, 270, 0);
        }
    }

    public void OnJump(InputAction.CallbackContext ctx)
    {
        if(ctx.started)
        {
            Debug.Log("Jump!");
            if(doubleJumpAvailable)
            {
                doubleJumpAvailable = false;
                gravityValue = -20;
                playerVelocity.y = 0;
                playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            } else 
            {
                timeSinceJumpPress = jumpBufferTimer;
            }
        
            // Handle basic jumps/buffered jumps
            if((timeSinceJumpPress > 0f) && groundedPlayer)
            {
                doubleJumpAvailable = true;
                Debug.Log("Enabled Double Jump");
                timeSinceJumpPress = 0f;
                playerVelocity.y += playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            }
        }
    }

    private void OnFastfall()
    {
        if (playerVelocity.y < 1 && !groundedPlayer)
        {
            gravityValue = -150;
        }
    }

    public void OnRecover(InputAction.CallbackContext ctx)
    {
        if (recoveryAvailable && groundedPlayer)
        {
            gravityValue = -20;
            playerVelocity.y = 0;
            playerVelocity.y += playerVelocity.y += Mathf.Sqrt(jumpHeight * -6f * gravityValue);
            recoveryAvailable = false;
            doubleJumpAvailable = true;
        }
        else if (recoveryAvailable)
        {
            gravityValue = -20;
            playerVelocity.y = 0;
            playerVelocity.y += playerVelocity.y += Mathf.Sqrt(jumpHeight * -6f * gravityValue);
            recoveryAvailable = false;
        }
    }

    public float getGravity()
    {
        return gravityValue;
    }

    public float getJumpHeight()
    {
        return jumpHeight;
    }
}
