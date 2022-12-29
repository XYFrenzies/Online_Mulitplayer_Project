
public abstract class BasePlayerController
{
    protected PlayerStateManager PSManager;

    public BasePlayerController(PlayerStateManager playerStateManager) 
    {
        PSManager = playerStateManager;
    }

    /// <summary>
    /// When a new controller is entered, non of the other controllers are referenced.
    /// </summary>
    public abstract void EnterController();

    /// <summary>
    /// Exits out of the current controller.
    /// </summary>
    public abstract void ExitController();

    /// <summary>
    /// Updates the maths of the game.
    /// </summary>
    public abstract void UpdateLogic();

    /// <summary>
    /// Updates the physics and the movement in the game.
    /// </summary>
    public abstract void UpdatePhysics();
}
