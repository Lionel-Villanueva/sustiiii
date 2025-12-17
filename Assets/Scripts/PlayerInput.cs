using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    private InputSystem_Actions inputActions;

    public static event Action<Vector2> OnMove;
    public static event Action<Vector2> OnMousePosition;
    public static event Action OnShoot;

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

        inputActions.Player.MousePosition.performed += InputMousePosition;
        inputActions.Player.MousePosition.started += InputMousePosition;
        inputActions.Player.MousePosition.canceled += InputMousePosition;

        inputActions.Player.Attack.performed += InputShoot;
        inputActions.Player.Attack.started += InputShoot;
        inputActions.Player.Attack.canceled += InputShoot;
    }

    private void OnDisable()
    {
        inputActions.Player.Move.performed -= InputMove;
        inputActions.Player.Move.started -= InputMove;
        inputActions.Player.Move.canceled -= InputMove;

        inputActions.Player.MousePosition.performed -= InputMousePosition;
        inputActions.Player.MousePosition.started -= InputMousePosition;
        inputActions.Player.MousePosition.canceled -= InputMousePosition;

        inputActions.Player.Attack.performed -= InputShoot;
        inputActions.Player.Attack.started -= InputShoot;
        inputActions.Player.Attack.canceled -= InputShoot;

        inputActions.Disable();
    }

    private void InputMove(InputAction.CallbackContext context)
    {
        OnMove?.Invoke(context.ReadValue<Vector2>());
    }

    private void InputMousePosition(InputAction.CallbackContext context)
    {
        OnMousePosition?.Invoke(context.ReadValue<Vector2>());
        Debug.Log(context.ReadValue<Vector2>());
    }

    private void InputShoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            OnShoot?.Invoke();
        }

    }
}
