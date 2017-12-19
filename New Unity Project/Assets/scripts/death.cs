using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour {
	public Famvas canvas;
	public Boss bass;
	public List<Boss> bosses = new List<Boss> (); 
	public void OnCollisionEnter2D(Collision2D collider){
		GameObject other = collider.gameObject;
		if (collider.gameObject.tag == "enemy") {
			GameObject b = GameObject.FindGameObjectWithTag ("Boss");
			GameObject g = GameObject.FindGameObjectWithTag ("canvas");
			bass = b.GetComponent<Boss> ();
			canvas = g.GetComponent<Famvas> ();
			bass.playerLost = true;
			canvas.turnOff = false;
			Destroy (this.gameObject);
		}
	}
}