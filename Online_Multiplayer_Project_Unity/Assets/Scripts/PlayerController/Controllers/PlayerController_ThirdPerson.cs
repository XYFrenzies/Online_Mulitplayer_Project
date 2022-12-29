using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController_ThirdPerson : MonoBehaviour
{
    private FirstPersonInput playerActionAsset;
    private InputAction move;

    private Rigidbody rb;

    [SerializeField]
    private float movementForce = 1f;

    [SerializeField]
    private float jumpForce = 5f;

    [SerializeField]
    private float maxSpeed = 5f;

    private Vector3 forceDirection = Vector3.zero;

    [SerializeField]
    private Camera playerCamera;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody>();
        playerActionAsset = new FirstPersonInput();
    }

    private void OnEnable()
    {
        playerActionAsset.ThirdPerson.Jump.started += StartJump;
        move = playerActionAsset.ThirdPerson.Move;
        playerActionAsset.ThirdPerson.Enable();
    }
    private void OnDisable()
    {
        playerActionAsset.ThirdPerson.Jump.started -= StartJump;
    }

    private void FixedUpdate()
    {
        forceDirection += move.ReadValue<Vector2>().x * GetCameraRight(playerCamera);
        forceDirection += move.ReadValue<Vector2>().y * GetCameraForward(playerCamera);

        rb.AddForce(forceDirection, ForceMode.Impulse);

        forceDirection = Vector3.zero;

        if (rb.velocity.y < 0f)
        {
            rb.velocity += Vector3.down * Physics.gravity.y * Time.fixedDeltaTime;
        }

        Vector3 horVeclocity = rb.velocity;
        horVeclocity.y = 0;
        if (horVeclocity.sqrMagnitude > maxSpeed * maxSpeed) 
        {
            rb.velocity = horVeclocity.normalized * maxSpeed;
        }

        LookAt();
    }

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

    private Vector3 GetCameraForward(Camera playerCamera)
    {
        Vector3 forward = playerCamera.transform.forward;
        forward.y = 0;
        return forward.normalized;
    }

    private Vector3 GetCameraRight(Camera playerCamera)
    {
        Vector3 right = playerCamera.transform.right;
        right.y = 0;
        return right.normalized;
    }

    private void StartJump(InputAction.CallbackContext obj) 
    {
        if (IsGrounded())
        {
            forceDirection += Vector3.up * jumpForce;
        }
    }

    private bool IsGrounded() 
    {
        Ray ray = new Ray(this.transform.position + Vector3.up * 0.25f, Vector3.down);
        if (Physics.Raycast(ray, out RaycastHit hit, 0.3f))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
