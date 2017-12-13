using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrisbeeL : MonoBehaviour {
	public Rigidbody2D frb;
	public IEnumerator move;
	public Vector2 pt1 = new Vector2 (-4, -2);
	public Vector2 pt2 = new Vector2 (7, 1);

	public void Start(){
		frb = gameObject.GetComponent<Rigidbody2D> ();
		move = rhee ();
		StartCoroutine (move);
	}
	public IEnumerator rhee(){
		frb.velocity = pt1 * 5;
		yield return new WaitForSeconds (3);
		frb.velocity = pt2 * 5;
	}
}