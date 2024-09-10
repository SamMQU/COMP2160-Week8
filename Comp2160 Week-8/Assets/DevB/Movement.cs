using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private PlayerMovement actions;
    private InputAction movementAction;
    private Vector2 movementInput;

    void Awake()
    {
        actions = new PlayerMovement();
        movementAction = actions.FindAction("Movement", throwIfNotFound: true);
    }

    void OnEnable()
    {
        movementAction.Enable();
        movementAction.performed += OnMovementPerformed;
        movementAction.canceled += OnMovementCanceled;
    }

    void OnDisable()
    {
        movementAction.Disable();
        movementAction.performed -= OnMovementPerformed;
        movementAction.canceled -= OnMovementCanceled;
    }

    private void OnMovementPerformed(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }

    private void OnMovementCanceled(InputAction.CallbackContext context)
    {
        movementInput = Vector2.zero;
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 movement = new Vector3(movementInput.x, movementInput.y, 0);
        transform.Translate(movement * Time.deltaTime);
    }
}
