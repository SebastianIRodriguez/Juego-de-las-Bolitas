using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntoV : MonoBehaviour {

	public finish manager;

	public respawn r;

	void OnCollisionEnter(Collision other) {
		if(other.gameObject.CompareTag("BolaV"))
		{
			manager.sumar ();
			manager.Ongreen = true;
		}
		if(other.gameObject.CompareTag("Player"))
		{
			r.last = false;
		}
		if(other.gameObject.CompareTag("BolaR"))
		{
			manager.Onred = false;
		}
	}
}
