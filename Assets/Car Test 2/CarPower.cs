using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPower : MonoBehaviour
{
    public Rigidbody rb;
    public float power = 0f;
    public float throttle = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        throttle = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        rb.AddForce(power * throttle * Time.deltaTime * transform.forward);
    }
}
