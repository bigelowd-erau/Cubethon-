using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public PlayerMovement playerMovement;
    Vector3 calcOffset;

    // Update is called once per frame
    void Update()
    {
        //set the camera position to the player position
        //transformed by the offset defined in the editor
        ///calcOffset = new Vector3(offset.x * Mathf.Sin(playerMovement.playerRotation), offset.y * Mathf.Cos(playerMovement.playerRotation), offset.z);
        transform.position = new Vector3(transform.position.x, transform.position.y, player.position.z + offset.z);
        //transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, playerMovement.playerRotation));
    }
}
