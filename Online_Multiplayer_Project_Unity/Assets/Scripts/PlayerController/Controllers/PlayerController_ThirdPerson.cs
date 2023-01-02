public class PlayerController_ThirdPerson : BasePlayerController
{
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
        AddForceToPlayer();

        VelocitySpeedCheck();

        LookAt();
    }
}
