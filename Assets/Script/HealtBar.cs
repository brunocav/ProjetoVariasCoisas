using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealtBar : MonoBehaviour {
	Image timeBar;
	float maxvida = 100f;
	public static float vida;
	// Use this for initialization
	void Start () {
		timeBar = GetComponent<Image>();
		vida = maxvida;
	}
	
	// Update is called once per frame
	void Update () {
		timeBar.fillAmount = vida/maxvida;
		if (Input.GetKey("up")){
			vida -= 0.20f;
			
		}
	}
}
