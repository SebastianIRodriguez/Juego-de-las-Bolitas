using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotador : MonoBehaviour {
	public myGameManager manager;
	private float limiteInicioRotacion;

	void Start(){
		limiteInicioRotacion = manager.time / 4;
	}
	
	void Update () {
		if(manager.time < limiteInicioRotacion)
			transform.Rotate (new Vector3 (0,30,0) * Time.deltaTime);
	}
}
