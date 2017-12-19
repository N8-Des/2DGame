using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrek : Boss {
	public float wait;
	public int amountSteve;
	public int amountEnd = 0;
	public int amountDrag;
	public Rigidbody2D rb;
	public void FixedUpdate(){
		wait += Time.deltaTime;
		if (wait >= 0.3) {
			amountSteve += 1;
			amountDrag += 1;
			wait = 0;
			Vector3 rando = new Vector3 (Random.Range(-2f, 2f), Random.Range(-2f, 2f), 0);
			GameObject onion = GameObject.Instantiate ((GameObject)Resources.Load ("Onion"));;
			rb = onion.GetComponent<Rigidbody2D> ();
			onion.transform.position = this.transform.position + rando;
			rb.velocity = rando * 3;
		}
		if (amountSteve >= 5) {
			amountSteve = 0;
			Vector3 stoffset = new Vector3 (Random.Range(-7.0f, 7.0f), 0, 0);
			GameObject steve = GameObject.Instantiate ((GameObject)Resources.Load ("Steve"));;
			steve.transform.position += stoffset;
		}
		if (amountDrag >= 13) {
			amountDrag = 0;
			amountEnd += 1;
			GameObject steve = GameObject.Instantiate ((GameObject)Resources.Load ("dragon"));;
			if (amountEnd >= 10) {
				ILost = true;
			}
		}
	}
}
