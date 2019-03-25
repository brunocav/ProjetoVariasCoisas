using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class MovimentoMouse : MonoBehaviour {


	RaycastHit hit;
	Rigidbody rb;
	Vector3 movimento;

	public bool movimentoEmRelacAoMouse = false;
	public float velocidadeMovimento = 10; 
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hit, 100)) {
			Vector3 playerToMouse = hit.point - transform.position;
			playerToMouse.y = 0;
			Quaternion newRotation = Quaternion.LookRotation (playerToMouse);
			rb.MoveRotation (newRotation);
			//Movimento
			if (movimentoEmRelacAoMouse) {

				Vector3 fowordDirection = new Vector3 (transform.forward.x, 0, transform.forward.z) * Input.GetAxis ("Vertical");
				Vector3 sideDirection = new Vector3 (transform.right.x, 0, transform.right.z) * Input.GetAxis ("Horizontal");
				Vector3 finalDirection = fowordDirection + sideDirection;
				if(finalDirection.magnitude > 1 ){
					finalDirection.Normalize ();
					}

				movimento = finalDirection * velocidadeMovimento * Time.deltaTime;
				rb.MovePosition (transform.position + movimento);
			} 
			else {
				movimento = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
				movimento = movimento.normalized * velocidadeMovimento * Time.deltaTime;
				rb.MovePosition (transform.position + movimento);
			}
		}
	}
}
