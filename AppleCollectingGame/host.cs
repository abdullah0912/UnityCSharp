using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class host : MonoBehaviour
{
	// public int _second = 10;    
	public GameObject _apple;
	float _timeInterval = 0.5f; // Zaman Aralığı
	float _remainingTime = 0.0f; // Kalan Süre
	bool _gameStopped = false;

    void Start()
    {
        // InvokeRepeating("AddApple", 0.0f ,0.5f);
    }
	
	public void PlayAgainBtn(){
		SceneManager.LoadScene("Scenes/SampleScene");
		Time.timeScale = 1.0f;
	}	

	public void StopBtn(){
		_gameStopped = !_gameStopped;

		if(_gameStopped == true){
			Time.timeScale = 0.0f;	
		}else{
			Time.timeScale = 1.0f;
		}
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
