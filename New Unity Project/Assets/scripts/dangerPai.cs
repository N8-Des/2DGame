using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dangerPai : MonoBehaviour {
	public float wait = 0;

	public void FixedUpdate(){
		wait += Time.deltaTime;
		if (wait >= 1.8) {
			GameObject net = GameObject.Instantiate ((GameObject)Resources.Load ("DeathList"));;
			net.transform.position = this.transform.position;
			Destroy (this.gameObject);
		}
	}
}
