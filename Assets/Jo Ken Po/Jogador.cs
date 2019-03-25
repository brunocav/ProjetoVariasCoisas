using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour {

	public static int VidasJ = 3;
	public static bool pedra,papel,tesoura;
	public static Jogador Instance; 
	public void Awaike (){
		Instance = this;
	}
	public void Pedra () {
		pedra = true;
		Sorteio ();
	}
	public void Papel () {
		papel = true;
		Sorteio ();

	}
	public void Tesoura () {
		tesoura = true;
		Sorteio ();

	}
	public void Sorteio (){
		PC.Instance.Sorteio ();
	}
	// Update is called once per frame
	void Update () {
		
	}
}
