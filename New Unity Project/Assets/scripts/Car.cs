using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {
	public Rigidbody2D frb;
	public IEnumerator move;
	public Vector2 pt1 = new Vector2 (-21, 0);
	public Vector2 pt2 = new Vector2 (8, 0);

	public void Start(){
		frb = gameObject.GetComponent<Rigidbody2D> ();
		move = rhee ();
		StartCoroutine (move);
	}
	public IEnumerator rhee(){
		frb.velocity = pt1;
		yield return new WaitForSeconds (2f);
		frb.velocity = pt2;
	}
}