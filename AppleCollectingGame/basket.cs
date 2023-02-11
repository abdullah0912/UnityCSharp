using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class basket : MonoBehaviour
{
    public float _speed;

    public int _score = 0;

    TextMeshProUGUI txtScore;
    
    // Start is called before the first frame update
    private void Start()
    {
        txtScore = GameObject.Find("Canvas/txtScore").GetComponent<TextMeshProUGUI>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Apple")
        {
            _score += 10;
            Debug.Log("Score: " + _score.ToString());
            txtScore.text = _score.ToString();
            
            Destroy(collision.gameObject);
        }
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
