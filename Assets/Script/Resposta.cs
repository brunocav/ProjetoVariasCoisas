using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Resposta : MonoBehaviour {
	public GameObject GO;
	public Button errado,errado2,errado3,certo;
	// Use this for initialization
	void Start () {
		GO.SetActive(true);
		certo.onClick.AddListener(() => RCerta());
		errado.onClick.AddListener(() => RErrada());
		errado2.onClick.AddListener(() => RErrada());
		errado3.onClick.AddListener(() => RErrada());

	}
	
	// Update is called once per frame
	void Update() {
		if (Input.GetKey("escape"))
			Application.Quit();

	
		foreach (Transform child in this.transform)
		{
			if (Input.GetKey(KeyCode.X))
			{
				child.gameObject.SetActive(false);
			}
			else if (Input.GetKey(KeyCode.Z))
			{
				child.gameObject.SetActive(true);
			}
		}
	}
	public void RCerta ()
	{
	
		Debug.Log ("certo");
		SceneManager.LoadScene("Certa", LoadSceneMode.Single);


	}
	public void RErrada ()
	{

		Debug.Log ("errado");
		SceneManager.LoadScene("Errado", LoadSceneMode.Single);


	}
}
