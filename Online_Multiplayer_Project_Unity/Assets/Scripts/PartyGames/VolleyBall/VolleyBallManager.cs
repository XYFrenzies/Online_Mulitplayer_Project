using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolleyBallManager : MonoBehaviour
{
    [SerializeField]
    private VolleyBallPhysics volleyBall;

    [SerializeField]
    private TMPro.TextMeshPro tmpText;

    private Rigidbody volleyBallRB;

    private void Awake()
    {
        volleyBall.onPlayerHit -= PlayerIsHit;
        volleyBall.onPlayerHit += PlayerIsHit;
        volleyBall.onGroundHit -= GroundIsHit;
        volleyBall.onGroundHit += GroundIsHit;

        volleyBallRB = volleyBall.GetComponent<Rigidbody>();
    }

    private void PlayerIsHit(GameObject player) 
    {
        SideOnPlayerController sideOnPlayer = player.GetComponent<SideOnPlayerController>();
        float powerPlayer = sideOnPlayer.OnPlayerHit();

        //May need its own function but is in here for now.
        //Math for the VolleyBall hit.
        Vector3 volleyBallDir = player.transform.position - volleyBall.transform.position;
        Vector3 planeTangent = Vector3.Cross(volleyBallDir, player.transform.forward);
        Vector3 planeNormal = Vector3.Cross(planeTangent, volleyBallDir);
        Vector3 reflection = Vector3.Reflect(player.transform.forward, planeNormal);

        volleyBallRB.velocity = reflection.normalized * powerPlayer;
    }

    private void GroundIsHit() 
    { 

    }
}
