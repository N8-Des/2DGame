using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour {
	public List<Boss> bosses = new List<Boss> (); 
	public void OnTriggerCollide(Collider collider){
		GameObject other = collider.gameObject;
		Ground ground = other.GetComponent<Ground> ();	
		if (ground == null) {
			Destroy (this.gameObject);
		}
	}
}