using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class PlayerInputScript : MonoBehaviour
{
    public float moveDirection;
    public bool shoot;

    public void OnMoveInput(InputAction.CallbackContext context)
    {
        moveDirection = context.ReadValue<float>(); //the way the input is set up, when you click a it sends a -1, nothing is 0, and d is 1
    }

    public void OnFireInput(InputAction.CallbackContext context)
    {
        if (context.performed) { shoot = true; }
        if (context.canceled) { shoot = false; }
    }
}
