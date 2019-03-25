using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimeLine : MonoBehaviour {

	Image timeBar;
	public float MazTime = 2f;
	float timeLeft;
	public GameObject timesUpText;


	// Use this for initialization
	void Start () {
		timesUpText.SetActive (false);
		timeBar = GetComponent<Image>();
		timeLeft = MazTime;
	}
	
	// Update is called once per frame
	void Update () {
		if (timeLeft > 0){
			timeLeft -= Time.deltaTime;
			timeBar.fillAmount = timeLeft / MazTime;
		}
		else{
			timesUpText.SetActive (true);
			Time.timeScale = 0;
		}
	}
}
