using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Apple")
        {
            float _rand = Random.Range(0f, 11.5f);

            collision.gameObject.transform.position = new Vector3 (_rand, 7, -7);
        }
    }
}
