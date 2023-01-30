using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class source_code : MonoBehaviour
{ // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        // transform.Rotate(0,1, 0);
    }

    // Soft collision
    
    private void OnTriggerEnter(Collider _collision)
    {
        Debug.Log("Object has touched!");
        // Debug.Log(_collision.gameObject.name);
        _collision.gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
    
    private void OnTriggerExit(Collider _collision)
    {
        Debug.Log("Touch over!");
    }
    
    private void OnTriggerStay(Collider _collision)
    {
        Debug.Log("Object is touching now!");
    }
}