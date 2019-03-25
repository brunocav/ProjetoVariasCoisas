using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	void OnCollisionEnter (Collision c)
	{
		if(c.gameObject.tag == "Player")
		{
			Destroy(gameObject);
			Debug.Log ("Monstro destruido com sucesso");
		}
	}
}
