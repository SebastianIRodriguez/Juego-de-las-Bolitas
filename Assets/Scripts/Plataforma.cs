using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour {
	public myGameManager manager;
	public float limiteInicioTraslacion; 
	private float deltax = 0.0005f;
	private float xfinal = 0;

	void Update () {
		if( xfinal < 1 && manager.time < limiteInicioTraslacion){
			transform.position = new Vector3 (0, xfinal, 0);
			xfinal += deltax;
		}
	}
}
