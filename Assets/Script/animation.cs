using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour {

	Animator AnimatorT;
	// Use this to decide if the GameObject can jump or not
	bool ataque;
	bool roda;
	public bool b = false;
	public bool a = false;
		

	void Start()
	{
		AnimatorT = gameObject.GetComponent<Animator>();
		roda = false;
	}

	void Update()
	{
		if (Input.GetKey (KeyCode.A) && a == true) {
			
			AnimatorT.SetBool ("inR", true);

			if (AnimatorT.GetBool ("inA")) {
				
				AnimatorT.SetBool ("inA", false);
				Debug.Log (a);
				b = false;

			}
		} else
			AnimatorT.SetBool ("inR", false);

		if (Input.GetKey (KeyCode.S) && b == true) {
			AnimatorT.SetBool ("inA", true);
			Debug.Log (b);
			a = false;
		} else {
			AnimatorT.SetBool ("inA", false);

	
		}
	}
}