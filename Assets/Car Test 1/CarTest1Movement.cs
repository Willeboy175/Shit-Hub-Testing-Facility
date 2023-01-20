using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTest1Movement : MonoBehaviour
{
    public Rigidbody rb;
    public Rigidbody joint;
    public float torque;
    public float steeringAngle;
    public bool steering;
    public bool invertSteering;
    public Vector3 movement;
    public Quaternion steer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.z = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        rb.AddTorque(Time.fixedDeltaTime * torque * movement); 
    }
}
