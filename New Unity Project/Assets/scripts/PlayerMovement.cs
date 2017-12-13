using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public Rigidbody2D rb;
	public float speed = 2;
	void FixedUpdate(){
		rb = gameObject.GetComponent<Rigidbody2D> ();
		Vector2 movementr = new Vector2 (speed, 0.0f);
		Vector2 movementl = new Vector2 (-speed, 0.0f);
		Vector2 jump = new Vector2 (0, 8);
		if (Input.GetKey (KeyCode.RightArrow)) {
			rb.velocity = (movementr * speed);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			rb.velocity = (movementl * speed);
		}
		if (Input.GetKeyDown(KeyCode.Z)) {
			rb.velocity = (jump * speed);
		}
	}
}