using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaColision : MonoBehaviour {

	public myGameManager manager;

	void OnCollisionEnter(Collision c){
		if (c.gameObject.tag == "BolaVerde" || c.gameObject.tag == "BolaAzul") {
			Destroy(c.gameObject);
			Destroy (gameObject);
			manager.terminarJuego(false);
		}
	}
}
