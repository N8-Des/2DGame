using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour {
	public Famvas canvas;
	public bool playerLost = false;
	public bool ILost = false;
	public void Update(){
		if (playerLost == true) {
			GameObject g = GameObject.FindGameObjectWithTag ("canvas");
			canvas = g.GetComponent<Famvas> ();
			canvas.turnOff = false;
			Destroy (this.gameObject);
		}
		if (ILost == true) {
			GameObject g = GameObject.FindGameObjectWithTag ("canvas");
			canvas = g.GetComponent<Famvas> ();
			canvas.turnOff = false;
			Destroy (this.gameObject);
		}
	}
}
