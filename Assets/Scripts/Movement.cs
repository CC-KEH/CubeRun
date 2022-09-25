using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce = 2000f;
    public float movementSpeed = 500f;

    void FixedUpdate()
    {
        rb.AddForce(0,0,ForwardForce*Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(movementSpeed*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-movementSpeed * Time.deltaTime, 0, 0);
        }
    }
}
