using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemeMan : Boss {
	public float waitspag;
	public int waitstopp;
	public int end;
	public float whomst;
	public void FixedUpdate(){
		waitspag += Time.deltaTime;
		if (waitspag >= 0.5f) {
			waitspag = 0;
			whomst += 1;
			waitstopp += 1;
			Vector3 spoff = new Vector3 (Random.Range (-8.0f, 8.0f), 0, 0);
			GameObject spaggot = GameObject.Instantiate ((GameObject)Resources.Load ("Spagoot"));;
			spaggot.transform.position += spoff;
			if (waitstopp >= 4) {
				waitstopp = 0;
				Vector3 stoff = new Vector3 (Random.Range (-8.0f, 8.0f), 0, 0);
				GameObject stup = GameObject.Instantiate ((GameObject)Resources.Load ("Stopp"));;
				stup.transform.position += stoff;
			}
			if (whomst >= 5) {
				end += 1;
				whomst = 0;
				Vector3 whooff = new Vector3 (0, Random.Range (-4.0f, 4.0f), 0);
				GameObject whomm = GameObject.Instantiate ((GameObject)Resources.Load ("Whomst"));;
				whomm.transform.position += whooff;
				if (end >= 10) {
					ILost = true;
				}
			}
		}
	}
}
