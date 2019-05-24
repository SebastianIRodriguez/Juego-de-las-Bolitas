using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour {

	public GameObject spawnZoneRoja;

	public GameObject spawnZoneVerde;

	public GameObject spawnZoneAzul;

	public GameObject spawnZonePlayer;

	public myGameManager manager;

	
	void OnCollisionEnter(Collision other) {
		if(other.gameObject.CompareTag("BolaRoja") && manager.BolaRojaEncestada == false)
		{
			Vector3 temp = other.gameObject.transform.position;

			temp.x = spawnZoneRoja.gameObject.transform.position.x;
			temp.y = spawnZoneRoja.gameObject.transform.position.y;
			temp.z = spawnZoneRoja.gameObject.transform.position.z;

			other.gameObject.transform.position = temp;

			manager.restarPunto();
		}

		if(other.gameObject.CompareTag("BolaVerde") && manager.BolaVerdeEncestada == false)
		{
			Vector3 temp = other.gameObject.transform.position;

			temp.x = spawnZoneVerde.gameObject.transform.position.x;
			temp.y = spawnZoneVerde.gameObject.transform.position.y;
			temp.z = spawnZoneVerde.gameObject.transform.position.z;

			other.gameObject.transform.position = temp;

			manager.restarPunto ();
		}

		if(other.gameObject.CompareTag("BolaAzul") && manager.BolaAzulEncestada == false)
		{
			Vector3 temp = other.gameObject.transform.position;

			temp.x = spawnZoneAzul.gameObject.transform.position.x;
			temp.y = spawnZoneAzul.gameObject.transform.position.y;
			temp.z = spawnZoneAzul.gameObject.transform.position.z;

			other.gameObject.transform.position = temp;

			manager.restarPunto ();
		}

		if (other.gameObject.tag == "Player") {
			Vector3 temp = other.gameObject.transform.position;

			temp.x = spawnZonePlayer.gameObject.transform.position.x;
			temp.y = spawnZonePlayer.gameObject.transform.position.y;
			temp.z = spawnZonePlayer.gameObject.transform.position.z;

			other.gameObject.transform.position = temp;
		}
	}
}
