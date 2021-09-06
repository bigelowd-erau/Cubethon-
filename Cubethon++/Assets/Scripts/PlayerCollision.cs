
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public PlayerGravity playerGravity;

    //when the player collides with another object
    void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "Floor")
        {
            //if the player's rotation is not the same as the floor
            if (movement.playerRotation != collision.collider.transform.rotation.z)
            {
                //temp future will hold logic for two
                movement.playerRotation = collision.collider.transform.rotation.eulerAngles.z;
                Debug.Log(collision.collider.transform.rotation.eulerAngles.z);
                playerGravity.ChangeGravity(movement.playerRotation);
            }
        }
        //if the object collided into has a tag of obstacle
        else if (collision.collider.tag == "Obstacle")
        {
            //disable player movment script
            movement.enabled = false;
            //call end game to reset the level
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
