using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorRandom : MonoBehaviour {
	public Color corInicial = Color.green;
	public bool alterarAlpha = false;
	public float tempoParaTrocar = 1;
	public float velocidadeCor = 5;
	public float cronometro;

	Color corRandom;
	Material materialObjeto;


	// Use this for initialization
	void Start () {
		materialObjeto = GetComponent<MeshRenderer> ().material;
		materialObjeto.color = corInicial;
		if (alterarAlpha == true) {
			corRandom = new Color (Random.Range (0.0f, 1.0f), Random.Range (0.0f, 1.0f), Random.Range (0.0f, 1.0f), Random.Range (0.0f, 1.0f));


		} else {
			corRandom = new Color (Random.Range (0.0f, 1.0f), Random.Range (0.0f, 1.0f), Random.Range (0.0f, 1.0f), 1);
		}
	}
	
	// Update is called once per frame
	void Update () {
		materialObjeto.color = Color.Lerp(materialObjeto.color, corRandom,Time.deltaTime * velocidadeCor);
		cronometro += Time.deltaTime;
		if(cronometro > tempoParaTrocar){
			cronometro = 0;
			if (alterarAlpha == true) {
				corRandom = new Color (Random.Range (0.0f, 1.0f), Random.Range (0.0f, 1.0f), Random.Range (0.0f, 1.0f), Random.Range (0.0f, 1.0f));
			} else {
				corRandom = new Color (Random.Range (0.0f, 1.0f), Random.Range (0.0f, 1.0f), Random.Range (0.0f, 1.0f), 1);
			}


		}
	}
}
