using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSteering : MonoBehaviour
{
    public Rigidbody rb;
    public Transform car;
    public float steeringAngle = 0f;
    public float carRotationY = 0f;
    public float steering = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        carRotationY = car.rotation.eulerAngles.y;
        steering = Input.GetAxis("Horizontal") * steeringAngle + carRotationY;
    }

    void FixedUpdate()
    {
        transform.rotation = Quaternion.AngleAxis(steering, transform.up);
    }
}
