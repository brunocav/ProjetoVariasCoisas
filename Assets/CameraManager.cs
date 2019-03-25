using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour {

	public Camera cameraLeft;
	public Camera cameraRight;
	public Camera cameraFull;

	public GameObject player1, player2;
	public float limitFullCamera;
	
	void Update () {

		// Verifica  distancia entre os jogadores 
		float d = Vector3.Distance(player1.transform.position, player2.transform.position);

		print (d);

		// Gerencia as camera de acordo com a distancia dos jogadores
		if (d > limitFullCamera) {

			cameraLeft.enabled = true;
			cameraRight.enabled = true;
			cameraFull.enabled = false;

			cameraLeft.fieldOfView = 30;
			cameraRight.fieldOfView = 30;

		} else {
			
			cameraLeft.enabled = false;
			cameraRight.enabled = false;
			cameraFull.enabled = true;

		}

	}
}
