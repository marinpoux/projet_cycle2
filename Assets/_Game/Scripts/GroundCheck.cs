using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [Header ("Layers")]
    [SerializeField]
    private LayerMask groundLayerMask;      // ground layer

    private bool isGrounded;
    private bool groundState;

    public event Action<bool> OnGroundedChange;

    private void Awake()
    {
        gameObject.GetComponent<BoxCollider>().isTrigger = true;    // make sure the box collider is used as a trigger !

        groundState = isGrounded;
    }

    private void OnTriggerEnter(Collider collider)
    //private void OnTriggerStay(Collider collider)
    {        
        // we check collision with the ground as well as with the player !
        isGrounded = collider != null && ((( 1 << collider.gameObject.layer) & groundLayerMask ) != 0);
        //Debug.Log("player grounded : " + isGrounded);

        // check if ground state changed
        if (isGrounded != groundState)
        {
            groundState = isGrounded;
            OnGroundedChange?.Invoke(groundState);      // fire event with new ground state
        }
    }


    private void OnTriggerExit(Collider collider)
    {
        isGrounded = false;
        //Debug.Log("player grounded : " + isGrounded);

        // check if ground state changed
        if (isGrounded != groundState)
        {
            groundState = isGrounded;
            OnGroundedChange?.Invoke(groundState);      // fire event with new ground state
        }
    }

    


}