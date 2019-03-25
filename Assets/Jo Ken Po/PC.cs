using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC : MonoBehaviour {
	public static int vidasPC = 3;
	public static bool pedra,papel,tesoura;
	public static PC Instance;
	public void Awaike (){
		Instance = this;
	}
	// Use this for initialization
	public void Pedra () {
		pedra = true;
	}
	public void Papel () {
		papel = true;

	}
	public void Tesoura () {
		tesoura = true;

	}
	public void Sorteio (){
		 int s = Random.Range (1,3);
		/*switch (s) {
		case 1:
			Pedra ();
			break;
		case 2:
			Papel ();
			break;	
		case 3:
			Tesoura ();
			break;

		}*/
		if (s == 1){
			Pedra ();

		}if (s == 2){
			Papel ();

		}if (s == 3){
			Tesoura ();

		}
	}
}
