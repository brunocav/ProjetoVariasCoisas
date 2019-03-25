using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorDeArmas : MonoBehaviour {

	 public int intelligence = 5;
	public GameObject arma1,arma2,arma3;

    
	void Update()
    {
        switch (intelligence)
        {
        case 5:
            print ("Why hello there good sir! Let me teach you about Trigonometry!");
            break;
        case 4:
            print ("Hello and good day!");
            break;
        case 3:
            print ("Whadya want?");
            break;
        case 2:
            print ("Grog SMASH!");
			arma3.SetActive (true);
			arma1.SetActive (false);
			arma2.SetActive (false);

			break;
        case 1:
            print ("Ulg, glib, Pblblblblb");
			arma2.SetActive (true);
			arma1.SetActive (false);
			arma3.SetActive (false);

			break;
		default:
			print ("Incorrect intelligence level.");
			arma1.SetActive (true);

			arma3.SetActive (false);
			arma2.SetActive (false);
            break;
        }
    }
}
