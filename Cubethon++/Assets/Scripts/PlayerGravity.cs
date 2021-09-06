using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravity : MonoBehaviour
{
    public void ChangeGravity(float rotation)
    {
        rotation = Mathf.Deg2Rad * rotation;
        Physics.gravity = new Vector3(20f*Mathf.Sin(rotation), -20f * Mathf.Cos(rotation), 0);
    }
}
