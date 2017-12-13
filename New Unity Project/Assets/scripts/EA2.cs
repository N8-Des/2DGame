using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EA2 : Boss {
	public float wait;
	public int simswait;
	public int bfwait;
	public int end;
	public void FixedUpdate(){
		wait += Time.deltaTime;
		if (wait >= 0.5f) {
			wait = 0;
			bfwait += 1;
			Vector3 offset = new Vector3 (Random.Range(-10f, 10f), 0, 0);
			GameObject ori = GameObject.Instantiate ((GameObject)Resources.Load ("Origin"));;
			ori.transform.position += offset;
			simswait += 1;
			if (simswait >= 10) {
				simswait = 0;
				Vector3 simsOff = new Vector3 (Random.Range(-6.0f, 6.0f), Random.Range(-6.0f, 6.0f), 0);
				GameObject sim = GameObject.Instantiate ((GameObject)Resources.Load ("Sims"));;
				sim.transform.position += simsOff;
			}
			if (bfwait >= 20) {
				end += 1;
				bfwait = 0;
				GameObject sim = GameObject.Instantiate ((GameObject)Resources.Load ("danger2"));;

			}
		}
	}
}