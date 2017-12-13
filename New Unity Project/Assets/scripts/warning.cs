using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warning : MonoBehaviour {
	public float wait = 0;

	public void FixedUpdate(){
		wait += Time.deltaTime;
		if (wait >= 1.2) {
			GameObject net = GameObject.Instantiate ((GameObject)Resources.Load ("Troomp"));;
			net.transform.position = this.transform.position;
			Destroy (this.gameObject);
		}
	}
}
