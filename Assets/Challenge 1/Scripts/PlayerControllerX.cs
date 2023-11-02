using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    private float verticalInput;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
       // rotationSpeed = verticalInput;

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys
       if(verticalInput > 0)
       {
            transform.Rotate(new Vector3(5,0,0) * rotationSpeed * Time.deltaTime);
            //Debug.Log("UP...");
       }
       if(verticalInput < 0)
       {
            transform.Rotate(new Vector3(-5,0,0) * rotationSpeed * Time.deltaTime);
            //Debug.Log("DOWN...");
       }
      
        
    }
}
