using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class light : MonoBehaviour
{   
    RaycastHit _object;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 forward = transform.TransformDirection(Vector3.left) * 10;
        // Debug.DrawRay(transform.position, forward, Color.green);

        if (Physics.Raycast(transform.position, Vector3.back, out _object, 10.0f))
        {
            if (_object.collider.gameObject.tag == "Player")
                 Debug.Log("Light touched the sphere!");
        }
    }
}
