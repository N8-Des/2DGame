using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class microwarning : MonoBehaviour {
	public float wait = 0;

	public void FixedUpdate(){
		wait += Time.deltaTime;
		if (wait >= 1.2) {
			GameObject net = GameObject.Instantiate ((GameObject)Resources.Load ("micro1"));;
			net.transform.position = this.transform.position;
			Destroy (this.gameObject);
		}
	}
}
