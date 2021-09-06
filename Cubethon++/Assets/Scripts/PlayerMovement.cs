using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //the player object's rigid body
    public Rigidbody rb;
    public float forwardForce;
    public float sidewaysforce;
    public float playerRotation = 0;
    float playerRadRot;

    // Fixedupdate is called at a fixed time interval
    void FixedUpdate()
    {
        //adds a consistent forward force to the player object
        rb.AddForce(0,0,forwardForce * Time.deltaTime);
        playerRadRot = Mathf.Deg2Rad * playerRotation;
        //if d is pressed on the keyboard
        if (Input.GetKey("d"))
        {   
            //adds a velocity change force to the player relative right 
            rb.AddForce(sidewaysforce*Time.deltaTime * Mathf.Cos(playerRadRot), sidewaysforce * Time.deltaTime * Mathf.Sin(playerRadRot), 0, ForceMode.VelocityChange);
        }
        //if a is pressed on the keyboard
        if (Input.GetKey("a"))
        {
            //adds a velocity change force to the player relative left
            rb.AddForce(-sidewaysforce * Time.deltaTime * Mathf.Cos(playerRadRot), -sidewaysforce * Time.deltaTime * Mathf.Sin(playerRadRot), 0, ForceMode.VelocityChange);

            Debug.Log(playerRotation);
        }
    }
}
