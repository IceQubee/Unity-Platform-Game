using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    //"OnCollisionEnter" triggers when something collides with stuff
    //"Collision" inbetween the () lets unity know we want some info about the collision and than yu can give that info a name
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
        }
    }

}
