using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Controller controller;
    private Vector2 direction;
    private Vector3 moveDirection;

    private CharacterController characterController;

    public float playerSpeed = 5f;
    public float jumpHeight = 1.5f;
    public float gravity = -9.81f;
    private float verticalVelocity = 0f;

    private void Awake()
    {
        controller = new Controller();  // Initialize controller here
        characterController = GetComponent<CharacterController>();
    }

    private void OnEnable()
    {
        controller.PlayerController.Move.performed += OnMove;
        controller.PlayerController.Jump.performed += OnJump;
        controller.PlayerController.Enable();
    }

    private void OnDisable()
    {
        if (controller != null)  // Null check before removing event listeners
        {
            controller.PlayerController.Move.canceled -=  OnMove;
            controller.PlayerController.Jump.canceled -= OnJump;
            controller.PlayerController.Disable();
        }
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }

    private void OnJump(InputAction.CallbackContext context)
    {
        if (characterController.isGrounded)  // Ensure player is grounded before jumping
        {
            verticalVelocity = Mathf.Sqrt(jumpHeight * -2f * gravity);
            Debug.Log("Jump");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Movement in the horizontal plane
        moveDirection.x = direction.x;
        moveDirection.z = direction.y;

        // Apply gravity
        if (characterController.isGrounded && verticalVelocity < 0)
        {
            verticalVelocity = -2f; // Small negative value to ensure grounded state
        }

        verticalVelocity += gravity * Time.deltaTime;

        moveDirection.y = verticalVelocity;

        // Move the character
        characterController.Move(moveDirection * playerSpeed * Time.deltaTime);
    }
}
