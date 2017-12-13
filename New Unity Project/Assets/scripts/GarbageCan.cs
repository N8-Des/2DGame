using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageCan : MonoBehaviour {
	public float wait;
	public float spawnTimes;
	public void FixedUpdate(){
		wait += Time.deltaTime;
		if (wait >= 1) {
			Vector3 up = new Vector3 (0, 12, 0);
			wait = 0;
			spawnTimes += 1;
			GameObject quality = GameObject.Instantiate ((GameObject)Resources.Load ("Quality"));;
			quality.transform.position = this.transform.position + up;
			if (spawnTimes >= 3) {
				Destroy (this.gameObject);
			}
		}
	}
}