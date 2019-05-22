using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour {

	public GameObject zonered;

	public GameObject zonegreen;

	public finish punto;

	public Transform LadoV, LadoR;

	public bool last=false;//false = verde, true = rojo
	
	void OnCollisionEnter(Collision other) {
		if(other.gameObject.CompareTag("BolaR"))
		{
			Vector3 temp = other.gameObject.transform.position;

			temp.x = zonegreen.gameObject.transform.position.x;
			temp.y = zonegreen.gameObject.transform.position.y;
			temp.z = zonegreen.gameObject.transform.position.z;

			other.gameObject.transform.position = temp;

			punto.restar ();
		}

		if(other.gameObject.CompareTag("BolaV"))
		{
			Vector3 temp = other.gameObject.transform.position;

			temp.x = zonered.gameObject.transform.position.x;
			temp.y = zonered.gameObject.transform.position.y;
			temp.z = zonered.gameObject.transform.position.z;

			other.gameObject.transform.position = temp;

			punto.restar ();
		}

		if (other.gameObject.tag == "Player") {
			if (last) {
				other.gameObject.transform.position = LadoV.position;
			} else {
				other.gameObject.transform.position = LadoR.position;
			}
		}
	}
}
