using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JogoManager : MonoBehaviour {
	public bool jogando =  true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		while(jogando == true){

			if (Jogador.pedra == true && PC.tesoura == true){
				print ("jogador Venceu");
				PC.vidasPC -= 1;
			}	
			else if (PC.pedra == true && Jogador.tesoura == true){
				print ("Pc Venceu");
				Jogador.VidasJ -= 1;
			}
			else if (Jogador.papel == true && PC.pedra == true){
				print ("jogador Venceu");
				PC.vidasPC -= 1;

			}	
			else if (PC.papel == true && Jogador.pedra == true){
				print ("Pc Venceu");
				Jogador.VidasJ -= 1;

			}
			else if (Jogador.tesoura == true && PC.papel == true){
				print ("jogador Venceu");
				PC.vidasPC -= 1;

			}	
			else if (PC.tesoura == true && Jogador.papel == true){
				print ("Pc Venceu");
				Jogador.VidasJ -= 1;

			}
			else if (PC.tesoura == true && Jogador.tesoura == true){
				print ("empate");
			}
			else if (PC.papel == true && Jogador.papel == true){
				print ("empate");
			}
			else if (PC.pedra == true && Jogador.pedra == true){
				print ("empate");
			}
			else if(Jogador.VidasJ <= 0){
				print ("Pc GAnhou");
				break;
			}
			else if(PC.vidasPC <= 0){
				print ("Jogador GAnhou");
				break;
			}

		}

	}
}
