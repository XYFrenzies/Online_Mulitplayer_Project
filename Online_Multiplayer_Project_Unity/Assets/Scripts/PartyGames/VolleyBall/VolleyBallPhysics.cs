using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolleyBallPhysics : MonoBehaviour
{
    public Action<GameObject> onPlayerHit;
    public Action onGroundHit;

    //For testing
    private bool hasHitOnce = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") && !hasHitOnce)
        {
            onGroundHit.Invoke();
            hasHitOnce = true;
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            onPlayerHit.Invoke(collision.gameObject);
        }
    }
}
