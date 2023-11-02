using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propellerSpin : MonoBehaviour
{
    private Vector3 propellerSpinVector;
    float z = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        propellerSpinVector = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        z += 5;
        transform.Rotate(new Vector3(0,0,z) * Time.deltaTime);
    }
}
