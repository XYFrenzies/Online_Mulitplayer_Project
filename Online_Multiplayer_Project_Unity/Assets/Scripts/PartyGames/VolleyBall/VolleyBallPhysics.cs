using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolleyBallPhysics : MonoBehaviour
{
    public Action onPlayerHit;
    public Action onGroundHit;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            onGroundHit.Invoke();
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            onPlayerHit.Invoke();
        }
    }
}
