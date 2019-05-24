using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotador : MonoBehaviour {
	public myGameManager manager;
	private float limiteInicioRotacion;
	private float velocidad = 1;
	private const float aceleracion = 0.3f;

	void Start(){
		limiteInicioRotacion = manager.time / 5;
	}
	
	void Update () {
		if(manager.time < limiteInicioRotacion){
			transform.Rotate (new Vector3 (0,(int)velocidad,0) * Time.deltaTime);
			velocidad += aceleracion;
		}
	}
}
