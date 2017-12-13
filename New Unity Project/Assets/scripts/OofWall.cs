using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OofWall : MonoBehaviour {
	public Rigidbody2D r2d2;
	public Vector2 fas = new Vector2(10, 0);
	public float time = 0;
	public void OnEnable(){
		r2d2 = gameObject.GetComponent<Rigidbody2D> ();
		r2d2.velocity = (fas);
	}
	public void FixedUpdate(){
		time += Time.deltaTime;
		if (time >= 2) {
			Destroy (this.gameObject);
		}
	}
}
