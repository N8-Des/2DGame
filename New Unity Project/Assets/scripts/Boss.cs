using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour {
	public bool playerLost = false;
	public void FixedUpdate(){
		if (playerLost) {
			Destroy (this.gameObject);
		}
	}
}
