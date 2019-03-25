using UnityEngine;
using System.Collections;

public class Players : MonoBehaviour {

	public GameObject cam;			// Camera atribuida ao jogador
	public bool isPlayer2;			// Atribui comando para o player 2, player 1 será o padrão
	public float speed;				// Velocidade de movimento do jogador

	float moveX, moveZ;				// Atribui valores nos eixos de movimentacao

	void Update () {

		// Move o jogador

		if (!isPlayer2) {

			// Comandos para o jogador 1
			moveX = Input.GetAxis("HorizontalP1") * speed * Time.deltaTime;
			moveZ = Input.GetAxis("VerticalP1") * speed * Time.deltaTime;
			transform.Translate (moveX, 0.0f, moveZ);

		} else {

			// Comandos para o jogador 2
			moveX = Input.GetAxis("HorizontalP2") * speed * Time.deltaTime;
			moveZ = Input.GetAxis("VerticalP2") * speed * Time.deltaTime;
			transform.Translate (moveX, 0.0f, moveZ);
		
		}

		// Move o camera em relacao ao jogador
		cam.transform.position = new Vector3(transform.position.x, cam.transform.position.y, transform.position.z - 10.0f);


	}


}
