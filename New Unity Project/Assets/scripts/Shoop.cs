using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoop : MonoBehaviour {
	public float wait = 0;
	public bool hasSpawned = false;

	public void FixedUpdate(){
		wait += Time.deltaTime;
		if (wait >= 2) {
			if (hasSpawned == false) {
				hasSpawned = true;
				wait = 0;
				GameObject net = GameObject.Instantiate ((GameObject)Resources.Load ("Lazer"));;
			}
		}
	}
}
