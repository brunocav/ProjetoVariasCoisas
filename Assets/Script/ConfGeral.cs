using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfGeral : MonoBehaviour {
	public GameObject menu;
	static public bool estaPausado;
	// Use this for initialization
	void Start () {
		menu = Instantiate (menu, menu.transform.position, menu.transform.rotation) as GameObject;
		Pause (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.X)) {
			Pause (!estaPausado);
		}
	}
	// Update is called once per frame
	void Pause (bool statusPause) {
		estaPausado = statusPause;
		menu.SetActive (estaPausado);
		if (estaPausado) {
			Time.timeScale = 0;
		} else {
			Time.timeScale = 1;

		}
	}
}
