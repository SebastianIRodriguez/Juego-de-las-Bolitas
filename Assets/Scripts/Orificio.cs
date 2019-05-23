using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orificio : MonoBehaviour {

	public string tagBola;

	public myGameManager manager;
	
	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == tagBola){
			manager.setBolaEncestada(tagBola);
		}
	}
	
}
