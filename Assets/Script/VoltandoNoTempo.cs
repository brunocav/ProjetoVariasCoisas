using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoltandoNoTempo : MonoBehaviour {
	public KeyCode teclaReverseTime = KeyCode.Y;
	public float frequencia_Hz = 30;
	public int maxFrames = 100;
	[Space(15)]
	public bool fixedUpdate_50Hz = false;
	//
	float freq;
	float cronometro;
	bool reverseTime = false;

	List<Vector3> posicoes = new List<Vector3>();
	List<Quaternion> rotacoes = new List<Quaternion>();
	List<Vector3> rbVelocity = new List<Vector3>();
	List<Vector3> rbAngularVelocity = new List<Vector3>();
	Rigidbody componentRig;

	void Start () {
		freq = 1 / frequencia_Hz;
		componentRig = GetComponent<Rigidbody> ();
	}

	void Update () {
		if (Input.GetKeyDown (teclaReverseTime)) {
			if (posicoes.Count > 1 && rotacoes.Count > 1) {
				reverseTime = true;
				if (componentRig) {
					componentRig.useGravity = false;
				}
			}
		}
		if (Input.GetKeyUp (teclaReverseTime)) {
			reverseTime = false;
			if (componentRig) {
				componentRig.useGravity = true;
				//explicar
				componentRig.velocity = rbVelocity[rbVelocity.Count - 1];
				componentRig.angularVelocity = rbAngularVelocity[rbAngularVelocity.Count - 1];
			}
		}
		if (!fixedUpdate_50Hz) {
			cronometro += Time.deltaTime;
			if (cronometro >= freq) {
				cronometro = 0;
				ChecarReverseTime ();
			}
		}
		if (reverseTime) {
			transform.position = Vector3.Lerp (transform.position, posicoes [posicoes.Count - 1], Time.deltaTime * 5.0f);
			transform.rotation = Quaternion.Lerp (transform.rotation, rotacoes [rotacoes.Count - 1], Time.deltaTime * 5.0f);
		}
	}

	void FixedUpdate(){
		if (fixedUpdate_50Hz) {
			ChecarReverseTime ();
		}
		if (componentRig) {
			if (reverseTime) {
				componentRig.velocity = Vector3.zero;
				componentRig.angularVelocity = Vector3.zero;
			}
		}
	}

	void ChecarReverseTime(){ 
		if (!reverseTime) {
			posicoes.Add (transform.position);
			rotacoes.Add (transform.rotation);
			//
			if (componentRig) {
				rbVelocity.Add (componentRig.velocity);
				rbAngularVelocity.Add (componentRig.angularVelocity);
			}
			//
			if (posicoes.Count > maxFrames) {
				posicoes.Remove (posicoes [0]);
				rotacoes.Remove (rotacoes [0]);
				if (componentRig) {
					rbVelocity.Remove (rbVelocity [0]);
					rbAngularVelocity.Remove (rbAngularVelocity [0]);
				}
			}
		} else {
			if (posicoes.Count > 1) {
				posicoes.Remove (posicoes [posicoes.Count - 1]);
				rotacoes.Remove (rotacoes [rotacoes.Count - 1]);
				if (componentRig) {
					rbVelocity.Remove (rbVelocity [rbVelocity.Count - 1]);
					rbAngularVelocity.Remove (rbAngularVelocity [rbAngularVelocity.Count - 1]);
				}
			}
		}
	}
}