using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ground : MonoBehaviour
{

	public float _life, _currentLife = 100.0f;
	Image lifePanel;
	public GameObject panel;
	
	private void Start(){
		lifePanel = GameObject.Find("Canvas/Image/lifePanel").GetComponent<Image>();
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Apple")
        {
            Destroy(collision.gameObject);
			_currentLife -= 10.0f;
			lifePanel.fillAmount = _currentLife / _life;

			if(_currentLife <= 0){
				panel.SetActive(true);
				Time.timeScale = 0.0f;
			}
        }
    }
}
