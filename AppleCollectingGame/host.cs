using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class host : MonoBehaviour
{
	// public int _second = 10;    
	public GameObject _apple;
	float _timeInterval = 0.5f;
	float _remainingTime = 0.0f;

    void Start()
    {
        // InvokeRepeating("AddApple", 0.0f ,0.5f);
    }
	
	void AddApple(){
		float _rand = Random.Range(0.0f, 11.5f);
		GameObject _newApple = Instantiate(_apple, new Vector3(_rand, 7, -7), Quaternion.identity);
	}
	
	private void Update(){
		if(Time.time >= _remainingTime){
			AddApple();
			_remainingTime = _timeInterval+ Time.time;
		}	
	}	

	/*
	void DecrementSeconds(){
		_second --;
		Debug.Log(_second.ToString());

		if(_second == 5)
			CancelInvoke("DecrementSeconds");
	}

    void Update()
    {
        Debug.Log(Time.time);
		Time.timeScale = 1.0f;
    }
	*/
}
