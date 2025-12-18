using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    private PlayerControls controls;
    private FirstPersonMovement movement;

    private void Awake()
    {
        controls = new PlayerControls();
        movement = GetComponent<FirstPersonMovement>();
    }

    private void OnEnable()
    {
        controls.Player.Enable();

        controls.Player.Move.performed += ctx =>
            movement.SetMoveInput(ctx.ReadValue<Vector2>());

        controls.Player.Move.canceled += ctx =>
            movement.SetMoveInput(Vector2.zero);

        controls.Player.Run.performed += _ =>
            movement.SetRunInput(true);

        controls.Player.Run.canceled += _ =>
            movement.SetRunInput(false);
    }

    private void OnDisable()
    {
        controls.Player.Disable();
    }
}
