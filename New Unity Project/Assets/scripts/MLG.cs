using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MLG : Boss {
	public float dorito;
	public float illuminati;
	public int win;
	public void FixedUpdate(){
		dorito += Time.deltaTime;
		illuminati += Time.deltaTime;
		if (dorito >= 0.2f) {
			dorito = 0;
			Vector3 randoDor = new Vector3 (Random.Range(-6.0f, 6.0f), 0, 0);
			GameObject onion = GameObject.Instantiate ((GameObject)Resources.Load ("Dorito"));;
			onion.transform.position += randoDor;
		}
		if (illuminati >= 0.9f) { 
			illuminati = 0;
			win += 1;
			Vector3 rando = new Vector3 (Random.Range(-7.0f, 7.0f), Random.Range(-7.0f, 7.0f), 0);
			GameObject ill = GameObject.Instantiate ((GameObject)Resources.Load ("Trindicat"));;
			ill.transform.position += rando;
			if (win >= 25) {
				//end game
			}
		}
	}
}
