using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma2 : MonoBehaviour {

	public GameObject bala,arma,arma2;
	// Use this for initialization
	public void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			StartCoroutine (Tiro ());
		}
	}
	
	// Update is called once per frame
	IEnumerator Tiro (){
		yield return new WaitForSeconds (0.1f);
		Instantiate (bala,arma.transform.position,transform.rotation);
		Instantiate (bala,arma2.transform.position,transform.rotation);

	}
}
