using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private PlayerMovement actions;
    private InputAction movementAction;

    void Awake()
    {
        actions = new PlayerActions();
        movementAction = actions.driving.movement;
        movementAction = Movement.PlayerActions.Movement;
    }
    void OnEnable()
    {
        movementAction.Enable();
    }
    void OnDisable()
    {
        movementAction.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
