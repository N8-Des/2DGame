using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryShaq : Boss {
	public float firePillar;
	public int actuallyCanada;
	public int end;
	public void FixedUpdate(){
		firePillar += Time.deltaTime;
		if (firePillar >= 0.5f) {
			firePillar = 0;
			actuallyCanada += 1;
			Vector3 rando = new Vector3 (Random.Range(-9.0f, 9.0f), 0, 0);
			GameObject flame = GameObject.Instantiate ((GameObject)Resources.Load ("Flame"));;
			flame.transform.position += rando;
			if (actuallyCanada >= 7) {
				actuallyCanada = 0;
				end += 1;
				GameObject onion = GameObject.Instantiate ((GameObject)Resources.Load ("Fireball"));;
				if (end >= 10) {
					ILost = true;
					Destroy (this.gameObject);
				}
			}
		}
	}
}
