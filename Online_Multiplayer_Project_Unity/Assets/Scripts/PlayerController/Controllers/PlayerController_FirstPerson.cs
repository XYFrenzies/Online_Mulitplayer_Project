using UnityEngine;
public class PlayerController_FirstPerson : BasePlayerController
{

    private float xRotation = 0f;
    private float yRotation = 0f;

    private float lookRotation = 0f;

    private void OnEnable()
    {
        playerActionAsset.FirstPerson.Jump.started += StartJump;
        move = playerActionAsset.FirstPerson.Move;
        playerActionAsset.FirstPerson.Enable();
        playerActionAsset.FirstPerson.MouseX.performed += ctx => xRotation = ctx.ReadValue<float>();
        playerActionAsset.FirstPerson.MouseY.performed += ctx => yRotation = ctx.ReadValue<float>();
    }
    private void OnDisable()
    {
        playerActionAsset.FirstPerson.Jump.started -= StartJump;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        AddForceToPlayer();

        VelocitySpeedCheck();

        LookAt();
    }

    public override void LookAt()
    {
        rb.transform.Rotate(Vector3.up, xRotation * playerStats.GetRotationSpeeds().x * Time.deltaTime);

        lookRotation -= yRotation;
        lookRotation = Mathf.Clamp(lookRotation, -85f, 85f);
        Vector3 targetRotation = transform.eulerAngles;
        targetRotation.x = xRotation;
        playerCamera.transform.eulerAngles = targetRotation;
    }
}
