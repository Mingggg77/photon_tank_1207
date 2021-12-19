using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankTurrent : MonoBehaviour
{
    // Start is called before the first frame update
    public void Turn(float rotationAmount)
    {
        // Adjust the rotation of the turret based on the player's input.
        transform.Rotate(0, rotationAmount, 0);
    }
}
