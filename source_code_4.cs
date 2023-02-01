using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject _square;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject new_square = Instantiate(_square, transform.position, Quaternion.identity);  
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
