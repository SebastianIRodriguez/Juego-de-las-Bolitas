using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntoRE : MonoBehaviour {

	public finish manager;

	public respawn r;

	void OnCollisionEnter(Collision other) {
		if(other.gameObject.CompareTag("BolaR"))
		{
			manager.sumar ();
			manager.Onred = true;
		}
		if(other.gameObject.CompareTag("Player"))
		{
			r.last = true;
		}
		if(other.gameObject.CompareTag("BolaV"))
		{
			manager.Ongreen = false;
		}
	}
}
