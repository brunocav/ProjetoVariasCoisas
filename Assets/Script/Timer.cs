using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float Cronometro;
    public Text TextoTempo;
	// Use this for initialization
	void Start () {
        TextoTempo.text = Cronometro.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        Cronometro = Time.time;
        TextoTempo.text = Cronometro.ToString();

        if (Cronometro >= 10.000000 && Cronometro <= 10.100000) {
            Debug.Log("10 segundos");
        }
    }
}
