using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public int _number = 25;

    public string _message = "Bucchelo Tech!";
    
    public string _usrname="Mahmut";

    public GameObject[] _gameobjects;
    
    
    // Start is called before the first frame update
    void Start()
    {
        if (_message == "Bucchelo Tech!")
            Debug.Log("True Message!");
        else
            Debug.Log("Wrong Message");
        
        Toplama();

        GetComponent<MeshRenderer>().enabled = false;
        GameObject.Find("Capsule").GetComponent<MeshRenderer>().enabled = false;

        _gameobjects = GameObject.FindGameObjectsWithTag("sphere");

        foreach (GameObject _object in _gameobjects)
            _object.GetComponent<MeshRenderer>().enabled = false;
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