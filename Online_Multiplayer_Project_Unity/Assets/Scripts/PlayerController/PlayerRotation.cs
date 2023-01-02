using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    private float rotationSpeedX = 1f;
    private float rotationSpeedY = 1f;

    public Vector2 GetRotationSpeeds()
    {
        return new Vector2(rotationSpeedX, rotationSpeedY);
    }

    public void UpdateRotationSpeed(float rotationX, float rotationY)
    {
        rotationSpeedX = rotationX;
        rotationSpeedY = rotationY;
    }
}
