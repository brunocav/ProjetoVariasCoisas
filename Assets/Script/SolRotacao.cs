using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolRotacao : MonoBehaviour {
	public int rotacao;
	public GameObject sol;
	// Use this for initialization
	void Start () {




	}
	
	// Update is called once per frame
	void Update () {
			
		transform.Rotate (rotacao, 0, 0);


	}
}
