using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScoreManager : MonoBehaviour {

		public int scoreAtualDoNivel;
		public int scoreMaximoSalvo;
		string nomeDaCena;

		void Start () {
			scoreAtualDoNivel = 0;
			scoreMaximoSalvo = 0;
			nomeDaCena = SceneManager.GetActiveScene ().name;
			//PlayerPrefs.DeleteKey (nomeDaCena + "score");
			if (PlayerPrefs.HasKey (nomeDaCena + "s")) {
				scoreMaximoSalvo = PlayerPrefs.GetInt (nomeDaCena + "s");
			}
		}

		void Update () {
			scoreAtualDoNivel = (int) transform.position.x;
			ChecarScore ();
		}

		void ChecarScore(){
			if (scoreAtualDoNivel > scoreMaximoSalvo) {
				scoreMaximoSalvo = scoreAtualDoNivel;
				PlayerPrefs.SetInt (nomeDaCena + "s", scoreMaximoSalvo);
			}
		}
	}