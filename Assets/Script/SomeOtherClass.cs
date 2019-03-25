using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Dictionary<string, BadGuy> badguys = new Dictionary<string,BadGuy>();
		BadGuy bg1 = new BadGuy("harvey", 50);
		BadGuy bg2 = new BadGuy("magneto", 150);
		BadGuy bg3 = new BadGuy("bruno", 90);

	
		badguys.Add ("ganso", bg1);
		badguys.Add ("neymar", bg2);

		BadGuy magneto = badguys ["neymar"];

		BadGuy temp = null;
		if (badguys.TryGetValue ("birds", out temp)) {
			//success!

		} else {
		
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
