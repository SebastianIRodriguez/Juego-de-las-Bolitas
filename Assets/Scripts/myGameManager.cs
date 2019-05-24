using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myGameManager : MonoBehaviour {

	public Text scoreText;
	public Text timeText;
	public Text mensajeFin;

	public int puntos = 0;
	public float time = 0;

	public bool BolaRojaEncestada, BolaVerdeEncestada, BolaAzulEncestada;

	void Start () {
		scoreText.text = "Score: " + puntos;
	}

	void FixedUpdate () {
		time -= Time.deltaTime;
		timeText.text = "Time: " + time.ToString("00.0");
		scoreText.text = "Score: " + puntos;

		if(time<=0 || puntos==0) {
			terminarJuego(false);
		}

		if (BolaRojaEncestada && BolaVerdeEncestada && BolaAzulEncestada) {
			terminarJuego(true);
		}

		if (Input.GetKey("q") && Time.timeScale == 0)
			Application.Quit ();
	}

	public void restarPunto () {
		puntos--;
	}

	public void sumarPunto () {
		puntos++;
	}

	public void setBolaEncestada(string tag){
		switch(tag){
			case "BolaVerde":
				BolaVerdeEncestada = true;
				break;
			case "BolaRoja":
				BolaRojaEncestada = true;
				break;
			case "BolaAzul":
				BolaAzulEncestada = true;
				break;
		}
		sumarPunto();
	}

	public void terminarJuego(bool gano){
		Time.timeScale = 0;

		if(gano){
			mensajeFin.text = "Ganaste!";
		}
		else {
			mensajeFin.text = "Perdiste!";
		}

	}

}
