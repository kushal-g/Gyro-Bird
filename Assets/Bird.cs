using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Linked");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            print("Flap");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            print("Left");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            print("Right");
        }
    }
}
