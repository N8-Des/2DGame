using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EAfight : Boss {
	public float wait;
	public int numbro;
	public int phase2;
	public IEnumerator microWarn;

	public void FixedUpdate(){
		wait += Time.deltaTime;
		if (wait >= 2) {
			wait = 0;
			numbro += 1;
			Vector3 random = new Vector3 (Random.Range(-10f, 10f), 0, 0);
			GameObject garbo = GameObject.Instantiate ((GameObject)Resources.Load ("Garbage"));;
			garbo.transform.position += random;
			if (numbro >= 3) {
				numbro = 0;
				microWarn = awful();
				StartCoroutine (microWarn);
			}
		}
	}
	public IEnumerator awful(){
		GameObject micro1 = GameObject.Instantiate ((GameObject)Resources.Load ("microindicator1"));;
		yield return new WaitForSeconds (2.4f);
		GameObject micro2 = GameObject.Instantiate ((GameObject)Resources.Load ("microindicator2"));;
		phase2 += 1;
		if (phase2 >= 4) {
			GameObject sim = GameObject.Instantiate ((GameObject)Resources.Load ("EA2"));;
			Destroy (this.gameObject);
		}
	}
}