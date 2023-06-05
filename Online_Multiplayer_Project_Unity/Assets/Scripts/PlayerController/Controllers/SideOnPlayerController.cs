using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideOnPlayerController : BasePlayerController
{
    [SerializeField, Range(0.5f,20f)]
    private float playerHitPower = 5f;

    private void OnEnable()
    {
        playerActionAsset.FirstPerson.Jump.started += StartJump;
        move = playerActionAsset.FirstPerson.Move;
        playerActionAsset.FirstPerson.Enable();
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

    public override float OnPlayerHit()
    {
        return playerHitPower;
    }
}
