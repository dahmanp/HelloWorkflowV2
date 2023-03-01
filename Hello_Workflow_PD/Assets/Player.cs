using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * 0.5f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * 0.5f;
        }
    }
}
