using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UsuarioC : MonoBehaviour {

	public float Cronometro;
	public Text TextoTempo;
	public Text pedraTemp,pedraEsp,pedraMent,pedraPoder,pedraAlma,pedraReal;
	public bool ppoder = true; 
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		PedraDoPoder ();


	}
	public void PedraDaAlma () {

	}
	public void PedraDoTempo () {

	}
	public void PedraDoEspaco () {


	}
	public void PedraDaRealidade () {

	}
	public void PedraDaMente () {

	}
	public void peguei () {
		ppoder = true;
	}
	void CronometroT () {
		Cronometro = Time.time;
		if (Cronometro >= 5.000000 && Cronometro <= 5.100000) {
			ppoder = false;
			transform.localScale = new Vector3 (1.1F, 1, 1);

		}

	}
	public void PedraDoPoder () {
		
		if(ppoder == true){
			CronometroT ();
			if (Input.GetButtonDown ("Jump")) {
				transform.localScale += new Vector3 (2.1F, 2, 2);
				Debug.Log ("Full Size");




			} 
		}
		else if (Input.GetKey ("z")){
			peguei ();
			Cronometro = 0;

		}
	}


}
