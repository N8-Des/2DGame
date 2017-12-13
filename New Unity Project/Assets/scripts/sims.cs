using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sims : MonoBehaviour {
	public float wait = 0;

	public void FixedUpdate(){
		wait += Time.deltaTime;
		if (wait >= 1.8) {
			wait = 0;
			GameObject net = GameObject.Instantiate ((GameObject)Resources.Load ("GreenLaser"));;
			net.transform.position = this.transform.position;
		}
	}
}
