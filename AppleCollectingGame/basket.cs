using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basket : MonoBehaviour
{
    public float _speed;

    public int _score = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Apple")
        {
            _score += 10;
            Debug.Log("Score: " + _score.ToString());

            collision.gameObject.transform.position = new Vector3 (7, 7, -7);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(_speed * Time.deltaTime, 0, 0);
        
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(-_speed * Time.deltaTime, 0, 0);
    }
}
