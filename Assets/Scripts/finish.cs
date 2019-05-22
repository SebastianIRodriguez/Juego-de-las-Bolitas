using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finish : MonoBehaviour {

	public Text scoreText;
	public Text timeText;

	public int puntos = 8;
	public float time = 50;

	public bool Onred, Ongreen;

	void Start () {
		scoreText.text = "Score: " + puntos;
	}

	void FixedUpdate () {
		time -= Time.deltaTime;
		timeText.text = "Time: " + time;
		scoreText.text = "Score: " + puntos;

		if(time<=0 || puntos==0) {
			timeText.text = "Perdiste";
			Time.timeScale = 0;
		}

		if (Onred && Ongreen) {
			timeText.text = "Ganaste";
			Time.timeScale = 0;
		}

		if (Input.GetKey("q") && Time.timeScale == 0)
			Application.Quit ();
	}

	public void restar () {
		puntos--;
	}

	public void sumar () {
		puntos++;
	}

}
