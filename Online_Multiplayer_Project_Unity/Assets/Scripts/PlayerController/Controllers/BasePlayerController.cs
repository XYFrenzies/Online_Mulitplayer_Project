using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// This class is the base player class for movement and logic.
/// </summary>
public class BasePlayerController: MonoBehaviour
{
    #region PlayerControls

    protected ControllerInput playerActionAsset;

    public PlayerRotation playerStats;

    protected InputAction move;

    protected Rigidbody rb;

    #endregion

    #region Serialized Objects and Variables

    [SerializeField]
    protected float movementForce = 1f;

    [SerializeField]
    protected float jumpForce = 5f;

    [SerializeField]
    protected float maxSpeed = 5f;

    [SerializeField]
    protected Camera playerCamera;

    #endregion

    #region Private Fields

    protected Vector3 forceDirection = Vector3.zero;

    private bool isJumping = false;

    private Vector3 jumpMovement;

    #endregion

    // Start is called before the first frame update
    public virtual void Awake()
    {
        rb = this.GetComponent<Rigidbody>();
        playerActionAsset = new ControllerInput();
    }

    /// <summary>
    /// Begins the jump.
    /// </summary>
    /// <param name="obj"></param>
    protected virtual void StartJump(InputAction.CallbackContext obj)
    {
        if (IsGrounded())
        {
            jumpMovement += Vector3.up * jumpForce;
            rb.AddForce(jumpMovement, ForceMode.Impulse);
        }
    }

    /// <summary>
    /// Raycast checks if the player is interacting with the floor.
    /// </summary>
    /// <returns>If it is grounded or not</returns>
    protected virtual bool IsGrounded()
    {
        Ray ray = new Ray(this.transform.position + Vector3.up * 0.25f, Vector3.down);
        if (Physics.Raycast(ray, out RaycastHit hit, 1.25f))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Gets the player camera's forward axis
    /// </summary>
    /// <param name="playerCamera">The current player's camera.</param>
    /// <returns>A vector 3 in the forward axis direction of the camera</returns>
    protected virtual Vector3 GetCameraForward(Camera playerCamera)
    {
        Vector3 forward = playerCamera.transform.forward;
        forward.y = 0;
        return forward.normalized;
    }

    /// <summary>
    /// Gets the player camera's right axis
    /// </summary>
    /// <param name="playerCamera">The current player's camera.</param>
    /// <returns>A vector 3 in the right axis direction of the camera</returns>
    protected virtual Vector3 GetCameraRight(Camera playerCamera)
    {
        Vector3 right = playerCamera.transform.right;
        right.y = 0;
        return right.normalized;
    }

    protected virtual void AddForceToPlayer() 
    {
        forceDirection += move.ReadValue<Vector2>().x * GetCameraRight(playerCamera);
        forceDirection += move.ReadValue<Vector2>().y * GetCameraForward(playerCamera);

        rb.AddForce(forceDirection * movementForce, ForceMode.Impulse);

        forceDirection = Vector3.zero;
    }

    /// <summary>
    /// Checks the velocity and the square magnitude of the player when moving and jumping. Can be overriden.
    /// </summary>
    protected virtual void VelocitySpeedCheck() 
    {
    }

    public virtual void LookAt()
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

    public virtual float OnPlayerHit() 
    {
        return 0;
    }
}
