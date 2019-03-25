using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Array : MonoBehaviour {
	public Text tx;
	public int cont = 0;
	public float[] values;
	// Use this for initialization
	void Start () {

		foreach (float value in values) {
			print (values);

		}
		values = new float[10];
		values [0] = 5.0f;
	}
	
	// Update is called once per frame
	public void U () {
		if( cont == 0 && values[1]!= null){
			
			values [1] = 2.0f;
			tx.text = values [1].ToString ();
			cont += 1;

		}else if( cont == 1 && values[2]!= null){

			values [2] = 3.0f;			
			tx.text = values [2].ToString ();

			cont += 1;
		}else if( cont == 2 && values[3]!= null){

			values [3] = 3.0f;
			tx.text = values [3].ToString ();

			cont += 1;
		}
		
	}
}
