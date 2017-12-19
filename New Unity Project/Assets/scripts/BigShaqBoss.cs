using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigShaqBoss : Boss {
	public float wait;
	public int carWait;
	public int phase2;
	public Vector3 offset = new Vector3 (0, 3);

	public void FixedUpdate(){
		wait += Time.deltaTime;
		if (wait >= 2) {
			wait = 0; 
			carWait += 1;
			GameObject Fr1 = GameObject.Instantiate ((GameObject)Resources.Load ("FrisbeeL"));;
			GameObject Fr2 = GameObject.Instantiate ((GameObject)Resources.Load ("FrisbeeR"));;
			if (carWait >= 3) {
				carWait = 0;
				phase2 += 1;
				GameObject Fr1b = GameObject.Instantiate ((GameObject)Resources.Load ("FrisbeeL"));;
				Fr1b.transform.position += offset;
				GameObject Fr2b = GameObject.Instantiate ((GameObject)Resources.Load ("FrisbeeR"));;
				Fr2b.transform.position += offset;
				GameObject car = GameObject.Instantiate ((GameObject)Resources.Load ("Car"));;
				if (phase2 >= 9) {
					GameObject Anrgu = GameObject.Instantiate ((GameObject)Resources.Load ("AngryShaq"));;
					Anrgu.transform.position = this.transform.position;
					Destroy (this.gameObject);
				}
			}
		}
	}
}
