using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    // this referces to the rigidbody component called "rb"
    // "public" makes it so yu can see/edit it in the inspector
    public Rigidbody rb;

    //"float" is a data type
    //the "f" in "2000f" signals that its a "float"
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // gebruikt "FixedUpdate" zodra je bezig ben met Physics
    void FixedUpdate ()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // add a force of 2000 on the z-axis to the rigidbody called "rb"
                                                          // "Time.deltaTime" does math stuff so it doesnt matter what framerate yu have"
        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //"ForceMode" specifies in what way you apply force (this is added last
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
