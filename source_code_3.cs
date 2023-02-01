using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class source_code_3 : MonoBehaviour
{

    private void Start()
    {   
        // We use this command to disable the object and all working properties.
        // Object disabled
        gameObject.SetActive(false);
        Debug.Log("Object disabled!");
        
        // Object enabled
        gameObject.SetActive(true);
        Debug.Log("Object enabled!");
        
        /*
         * Another way to delete objects is using Destroy method, for example 👇
         * Destroy(gameObject);
         * This code will remove the object from the projrct completely & you can't access or return it again.
         * Destroy(gameObject,5);
         * Also this code will remove the object but in 5 seconds as we wrote.
         */
    }
    
    // The function that contains the codes that will run continuously in the project is update.
    // Status query is made with if blocks below and a keyboard click message is given.
    private void Update()
    {   
        // Moving objects with Transform.
        
        /*
        // Code that runs when clicking the corresponding key on the keyboard.
        if (Input.GetKeyDown(KeyCode.RightArrow))
            Debug.Log("Right arrow key pressed!");
        
        // The code that runs when we take our finger off the relevant key on the keyboard.
        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("Pulled from the right arrow key!");
        
        // If we want the codes to run as long as the button is clicked, we use the following method.
        if (Input.GetKey(KeyCode.RightArrow))
            Debug.Log("Clicking the right arrow button!");
        
        
        // Code that runs when clicking the corresponding key on the mouse
        if (Input.GetMouseButtonDown(1))
            Debug.Log("Right clicked!");
        
        // The code that runs when we take our finger off the relevant key on the keyboard.
        if (Input.GetMouseButtonDown(0))
            Debug.Log("Left clicked!");
        
        
        // X direction
        // As soon as the right button is clicked, it moves forward one unit in the x plane.
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(1 * Time.deltaTime, 0, 0);
        
        // Clicking the right button moves back one unit in the x plane.
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(-1 * Time.deltaTime, 0, 0);
        // -1.deltaTime = Space.World
        
        
        // Y direction
        // As soon as the right button is clicked, it moves forward one unit in the x plane.
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(0, 1 * Time.deltaTime, 0);
        
        // Clicking the right button moves back one unit in the x plane.
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(0, -1 * Time.deltaTime, 0);*/

        
        // Moving objects with rigidbody.
        
        if (Input.GetKey(KeyCode.RightArrow))
            
            GetComponent<Rigidbody>().velocity = transform.right * 100 * Time.deltaTime;
        
        if (Input.GetKey(KeyCode.LeftArrow))
            GetComponent<Rigidbody>().velocity = transform.right * -100 * Time.deltaTime;
        
    }
}
