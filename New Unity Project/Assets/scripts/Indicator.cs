using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicator : MonoBehaviour {
	public float wait = 0;

	public void FixedUpdate(){
		wait += Time.deltaTime;
		if (wait >= 0.4) {
			GameObject net = GameObject.Instantiate ((GameObject)Resources.Load ("Illuminati"));;
			net.transform.position = this.transform.position;
			Destroy (this.gameObject);
		}
	}
}
