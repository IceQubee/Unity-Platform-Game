using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    //makes a public variable that referce to a "transform" CALLED "player" (drag the player object to the public variable in the inspector to add"
    public Transform player;
    //"Vector3" stores 3 floats (usefull for storing positions)
    public Vector3 offset;

    // Update is called once per frame
    void Update () {
        //if yu type "transform" without a capital "T" it refece to "this object" aka the GameObject this script is refering to (in this case the player camera)
        transform.position = player.position + offset;
    }
}
