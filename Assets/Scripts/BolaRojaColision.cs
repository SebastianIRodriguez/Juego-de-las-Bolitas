using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaRojaColision : MonoBehaviour {

	void OnCollisionEnter(Collision c){
		if (c.gameObject.tag == "BolaVerde" || c.gameObject.tag == "BolaAzul") {
			Destroy(c.gameObject);
			Destroy (gameObject);
			Time.timeScale = 0;

		}
	}
}
