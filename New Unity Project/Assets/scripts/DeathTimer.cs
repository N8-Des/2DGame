using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTimer : MonoBehaviour {
	public float Lifetime;
	public float time = 0;
	public void FixedUpdate(){
		time += Time.deltaTime;
		if (time >= Lifetime) {
			Destroy (this.gameObject);
		}
	}
}
