using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public int _number = 25;

    public string _message = "Bucchelo Tech!";
    
    public string _usrname="Mahmut";
    
    // Start is called before the first frame update
    void Start()
    {
        if (_message == "Bucchelo Tech!")
            Debug.Log("True Message!");
        else
            Debug.Log("Wrong Message");
        
        Toplama();

    }
    void Toplama()
    {
        _number += _number;
        Debug.Log(_number.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 1, 0);
    }
}
