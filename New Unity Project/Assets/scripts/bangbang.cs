using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bangbang : MonoBehaviour {
	public float wait;
	public int shottimes;

	public void FixedUpdate(){
		wait += Time.deltaTime;
		if (wait >= 0.6){
			wait = 0;
			shottimes += 1;
			GameObject Rcom = GameObject.Instantiate ((GameObject)Resources.Load ("bullet1"));;
			if (shottimes >= 4) {
				Destroy (this.gameObject);
			}
		}
	}
}
