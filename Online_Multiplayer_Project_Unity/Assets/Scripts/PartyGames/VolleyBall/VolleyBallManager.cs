using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolleyBallManager : MonoBehaviour
{
    [SerializeField]
    private BasePlayerController playerController;

    [SerializeField]
    private VolleyBallPhysics volleyBall;

    [SerializeField]
    private TMPro.TextMeshPro tmpText;

    private void Awake()
    {
        volleyBall.onPlayerHit -= PlayerIsHit;
        volleyBall.onPlayerHit += PlayerIsHit;
        volleyBall.onGroundHit -= GroundIsHit;
        volleyBall.onGroundHit += GroundIsHit;
    }

    private void PlayerIsHit() 
    {
        float powerPlayer = playerController.OnPlayerHit();
    }

    private void GroundIsHit() 
    { 

    }
}
