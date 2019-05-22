using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotato2 : MonoBehaviour {
	public finish tiem;
	private float mitad;
	void Start(){
		mitad = tiem.time*0.25f;
	}
	void Update () {
		if(tiem.time<mitad)transform.Rotate (new Vector3 (0,30,0) * Time.deltaTime);
	}
}
