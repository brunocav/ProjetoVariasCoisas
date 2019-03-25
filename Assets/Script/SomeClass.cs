using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClass : MonoBehaviour {

	// Use this for initialization
	void Start () {

		List<BadGuy> badguys = new List<BadGuy> ();
		//BadGuy _usuario = badguys[2];
		badguys.Add (new BadGuy ("bruno", 50));
		badguys.Add (new BadGuy ("anderson", 12));
		badguys.Add (new BadGuy ("filipe", 98));
		badguys.Sort ();
		foreach(BadGuy guy in badguys){
			print (guy.name+ " " + guy.power);
		//	print (_usuario.ToString());
		}
		badguys.Clear ();

	}
	public void B1(){
		List<BadGuy> badguys = new List<BadGuy> ();

		badguys.Add (new BadGuy ("gustavo", 150));
		foreach(BadGuy guy in badguys){
			print (guy.name+ " " + guy.power);
			//	print (_usuario.ToString());
		}


	}
}
