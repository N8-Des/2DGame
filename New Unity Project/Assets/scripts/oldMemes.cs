using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oldMemes : Boss {
	public float nyan;
	public float haram;
	public float shoop;
	public float rick;
	public int end;
	public void FixedUpdate(){
		nyan += Time.deltaTime;
		if (nyan >= 7) {
			nyan = 0;
			Vector3 noffset = new Vector3 (0, Random.Range (-6.0f, 6.0f), 0);
			GameObject nyanc = GameObject.Instantiate ((GameObject)Resources.Load ("Nyan"));;
			nyanc.transform.position += noffset;
		}
		haram += Time.deltaTime;
		if (haram >= 4) {
			haram = 0;
			Vector3 hoffset = new Vector3 (Random.Range (-6.0f, 6.0f), 0, 0);
			GameObject haramb = GameObject.Instantiate ((GameObject)Resources.Load ("Grave"));;
			haramb.transform.position += hoffset;
		}
		shoop += Time.deltaTime;
		if (shoop >= 7) {
			shoop = 0;
			GameObject shoopDa = GameObject.Instantiate ((GameObject)Resources.Load ("Shoop"));;
		}
		rick += Time.deltaTime;
		if (rick >= 9) {
			rick = 0;
			GameObject ricc = GameObject.Instantiate ((GameObject)Resources.Load ("RickAstley"));;
			end += 1;
			if (end >= 6) {
				ILost = true;
			}
		}
	}
}
