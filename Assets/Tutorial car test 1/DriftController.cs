using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Faction
{
    Player,
    Enemy,
    Neutral
};

public class DriftController : MonoBehaviour
{
    float inTrottle = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        
    }

    void InputKeyboard()
    {
        inTrottle = Input.GetAxisRaw("Throttle");
    }

    void Controller()
    {
        if (true)
        {

        }
    }
}
