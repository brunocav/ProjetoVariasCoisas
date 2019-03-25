using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsandoGetComponent : MonoBehaviour {


	public GameObject Objeto;
	public Color corInicial = Color.green;
	public bool alterarAlpha = false;
	private BoxCollider boxCol;
	Color corRandom;
	Material materialObjeto;
	public bool bCor = false;
	public int x = 1;
	public int y = 1;
	public int z = 1;


	public void InicioBotao () {

			materialObjeto = GetComponent<MeshRenderer> ().material;
			materialObjeto.color = corInicial;
		if (alterarAlpha == true) {
			corRandom = new Color (Random.Range (0.0f, 1.0f), Random.Range (0.0f, 1.0f), Random.Range (0.0f, 1.0f), Random.Range (0.0f, 1.0f));


		} 	
			boxCol.size = new Vector3(z,y,x);
		x += 2;
			
		z += 3;
			y +=2;
			Debug.Log ("ligou 2");
		transform.Translate (-2, Time.deltaTime, y, Space.World);
	}
	void Awake ()
	{
		boxCol = Objeto.GetComponent<BoxCollider>();
	}
	void Start ()
	{

	}
	public void s()
	{

		InicioBotao ();
	}

}
