using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Pedras : MonoBehaviour {

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
	public void PedraDoPoder () {
		if(ppoder == true){
		if (Input.GetButtonDown ("Jump")) {
			transform.localScale += new Vector3 (4.1F, 4, 4);
			Debug.Log ("Full Size");
				ppoder = false;


		} else {
			transform.localScale = new Vector3 (1.1F, 1, 1);
			//Debug.Log ("tamanho normal");

		}
		}
	}
}
