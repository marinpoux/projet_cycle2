using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAltControles : MonoBehaviour
{
    private InputAction movement;
    [SerializeField]
    private float movementForce = 10f;
    [SerializeField]
    private float rotationSpeed = 10f;
    private Vector3 forceDirection = new Vector3();
    private Rigidbody rb;

    private void OnEnable()
    {
        if (rb == null)
        {
            rb = this.GetComponent<Rigidbody>();
        }

        movement = InputManager.inputActions.PlayerAlt3d.Move;
        InputManager.inputActions.PlayerAlt3d.Exit.performed += ExitAlt;
    }

    void OnDisable()
    {
        InputManager.inputActions.PlayerAlt3d.Exit.performed -= ExitAlt;
    }

    private void ExitAlt(InputAction.CallbackContext obj)
    {
        InputManager.ToggleActionMap(InputManager.inputActions.PlayerControles3d);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            InputManager.ToggleActionMap(InputManager.inputActions.PlayerAlt3d);
        }
    }

    private void FixedUpdate()
    {
        
    }
}
