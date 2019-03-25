using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour {

	public Text Resultado;
	int cont;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void BotaoF () {
		cont += 10;
		Resultado.text = cont.ToString ();
	}
}
