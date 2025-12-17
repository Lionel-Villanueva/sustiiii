using System;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    private InputSystem_Actions inputActions;
    public static event Action<Vector2> OnMove;
    private void Awake()
    {
        inputActions = new InputSystem_Actions();
    }
    private void OnEnable()
    {
        inputActions.Enable();

        inputActions.Player.Move.performed += InputMove;
        inputActions.Player.Move.started += InputMove;
        inputActions.Player.Move.canceled += InputMove;
    }
    private void OnDisable()
    {
        inputActions.Player.Move.performed -= InputMove;
        inputActions.Player.Move.started -= InputMove;
        inputActions.Player.Move.canceled -= InputMove;

        inputActions.Disable();
    }
    private void InputMove(InputAction.CallbackContext context)
    {
        OnMove?.Invoke(context.ReadValue<Vector2>());
    }
}
