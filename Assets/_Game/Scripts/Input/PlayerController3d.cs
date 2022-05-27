using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController3d : MonoBehaviour
{
    private Transform player;       // parent object transform ; for easy access


    // INPUT
    private PlayerInputActions playerActionAsset;   // input action asset, containing our action map
    private InputAction move;                       // contains the reference to the "Move" action of our action map ; keeps the code cleaner ;
                                                    // most usefull for actions that are pulled rater than subscribed


    // MOVEMENT
    private Rigidbody rb;                           // needed for using the physics engine
    private Vector3 forceDirection = Vector3.zero;  // cash force direction for a given input

    [Header("Movement")]
    [SerializeField]
    private float movementForce = 1f;   // how hard is the rb being pushed ?
    [SerializeField]
    private float jumpForce = 5f;       // how much are we jumping ?
    [SerializeField]
    private float maxSpeed = 5f;        // limit to max force applied to the rb
    [SerializeField]
    private float maxFallSpeed = 5f;        // limit to max force applied to the rb
    private bool isGrounded;


    // CAMERA
    [Header("Camera")]
    [SerializeField]
    private Camera playerCamera;        // for movement based on camera direction


    // INITIALISATION
    private void Awake()
    {
        playerActionAsset = new PlayerInputActions();

        player = this.transform.root;               // highest transform in the hierarchy
        rb = player.GetComponent<Rigidbody>();      // in this case, the rigidbody is on the root parent (you could also make it state specific)

        rb.drag = 3.5f;     // prevents character from sliding all over ; may be removed or changed
    }

    private void OnEnable()
    {
        move = playerActionAsset.PlayerControles3d.Move;

        // SUBSCRIPTION TO INPUT EVENTS
        playerActionAsset.PlayerControles3d.Jump.performed += DoJump;
        //playerActionAsset.PlayerControles3d.Attack.performed += DoAttack;
        //playerActionAsset.PlayerControles3d.Use.performed += DoUse;
        //playerActionAsset.PlayerControles3d.Menu.performed += OpenMenu;

        // ENABLE ACTION MAP
        playerActionAsset.PlayerControles3d.Enable();       // don't forget to specify action map, or they will all be enabled

        // SUBSCRIPTION TO OTHER EVENTS
        player.GetComponentInChildren<GroundCheck>().OnGroundedChange += IsGrounded;    // as name suggests, event is fired when grounded state changes

    }

    private void OnDisable()
    {
        // UNSUBSCRIPTION TO INPUT EVENTS   --> prevents edge cases, makes sure the object is ONLY subscribed ONCE
        playerActionAsset.PlayerControles3d.Jump.performed -= DoJump;
        playerActionAsset.PlayerControles3d.Attack.performed -= DoAttack;
        playerActionAsset.PlayerControles3d.Use.performed -= DoUse;
        playerActionAsset.PlayerControles3d.Menu.performed -= OpenMenu;

        // DISABLE ACTION MAP
        playerActionAsset.PlayerControles3d.Disable();       // don't forget to specify action map, or they will all be disabled

        // UNSUB TO OTHER EVENTS
        player.GetComponentInChildren<GroundCheck>().OnGroundedChange -= IsGrounded;

    }


    // PHYSICS STEPS
    private void FixedUpdate()
    {
        // MOVEMENT
        // motion is relative to camera
        forceDirection += move.ReadValue<Vector2>().x * GetCameraRight(playerCamera) * movementForce;       // horizontal
        forceDirection += move.ReadValue<Vector2>().y * GetCameraForward(playerCamera) * movementForce;     // vertical

        LookAt();       // character looks at motion direction

        // apply force to rb
        rb.AddForce(forceDirection, ForceMode.Impulse);
        forceDirection = Vector3.zero;                      //reset force to stop continuous acceleration when letting go of controles

        // JUMP
        // fall
        if (rb.velocity.y < 0f)     // if character is falling, we want to increase fall speed
        {
            rb.velocity += Vector3.down * Physics.gravity.y * Time.fixedDeltaTime;
        }


        // CAP VALUES
        Vector3 horizontalVelocity = rb.velocity;
        horizontalVelocity.y = 0;
        if (horizontalVelocity.sqrMagnitude > maxSpeed * maxSpeed)
            rb.velocity = horizontalVelocity.normalized * maxSpeed + Vector3.up * rb.velocity.y;


        // CAMERA

    }

    private Vector3 GetCameraRight(Camera playerCamera)
    {
        Vector3 right = playerCamera.transform.right;
        right.y = 0;
        return right.normalized;
    }
    
    private Vector3 GetCameraForward(Camera playerCamera)
    {
        Vector3 forward = playerCamera.transform.forward;
        forward.y = 0;
        return forward.normalized;
    }


    // rotates character towards motion direction
    private void LookAt()
    {
        Vector3 direction = rb.velocity;
        direction.y = 0f;

        if (move.ReadValue<Vector2>().sqrMagnitude > 0.1f && direction.sqrMagnitude > 0.1f)
        {
            this.rb.rotation = Quaternion.LookRotation(direction, Vector3.up);
        }
        else
        {
            rb.angularVelocity = Vector3.zero;
        }
    }


    // when the grounded state changes, isGrounded is updated
    private void IsGrounded(bool isGrounded)
    {
        this.isGrounded = isGrounded;
    }


    private void DoJump(InputAction.CallbackContext obj)
    {
        if (isGrounded)       // prevents infinite jumping (no double jump in this case)
        {
            forceDirection += Vector3.up * jumpForce;
            Debug.Log("Jump !");
        }
    }

    private void DoAttack(InputAction.CallbackContext obj)
    {
        Debug.Log("Attack !");
    }

    private void DoUse(InputAction.CallbackContext obj)
    {
        Debug.Log("Use !");
    }

    private void OpenMenu(InputAction.CallbackContext obj)
    {
        Debug.Log("Open Menu");
    }
}