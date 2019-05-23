using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntoV : MonoBehaviour {

	public GameManager manager;

	public respawn r;

	void OnCollisionEnter(Collision other) {
		if(other.gameObject.CompareTag("BolaVerde"))
		{
			manager.sumarPunto ();
			manager.Ongreen = true;
		}
		if(other.gameObject.CompareTag("Player"))
		{
			r.last = false;
		}
		if(other.gameObject.CompareTag("BolaRoja"))
		{
			manager.Onred = false;
		}
	}
}
