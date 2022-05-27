using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuController : MonoBehaviour
{
    private void OnEnable()
    {
        InputManager.inputActions.MenuNavigation.Select.performed += ChangeScene;
    }

    private void OnDisable()
    {
        InputManager.inputActions.MenuNavigation.Select.performed -= ChangeScene;
    }

    private void ChangeScene(InputAction.CallbackContext obj)
    {
        InputManager.ToggleActionMap(InputManager.inputActions.MenuNavigation);
    }
}
