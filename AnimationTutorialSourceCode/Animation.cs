using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    Animator _anim;

    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            /*
             * Soruce code for SetBool function:
             
                bool _value = !_anim.GetBool("OtherAnimation");

                _anim.SetBool("OtherAnimation", _value);
            */

            _anim.SetTrigger("OtherAnimation");
        }
    }
}
