using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntoRE : MonoBehaviour {

	public GameManager manager;

	public respawn r;

	void OnCollisionEnter(Collision other) {
		if(other.gameObject.CompareTag("BolaRoja"))
		{
			manager.sumarPunto ();
			manager.Onred = true;
		}
		if(other.gameObject.CompareTag("Player"))
		{
			r.last = true;
		}
		if(other.gameObject.CompareTag("BolaVerde"))
		{
			manager.Ongreen = false;
		}
	}
}
