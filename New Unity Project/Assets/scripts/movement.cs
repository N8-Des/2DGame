using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	public float speed;             //Floating point variable to store the player's movement speed.
	public Animator jim;
	private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
	public Vector2 right = new Vector2 (2, 0);
	public Vector2 left = new Vector2 (-2, 0);
	public Vector2 noMove = new Vector2 (0, 0);
	// Use this for initialization
	void Start()
	{
		rb2d = GetComponent<Rigidbody2D> ();
		jim = GetComponent<Animator> ();
	}

	void FixedUpdate()
	{
		if (Input.GetKey(KeyCode.RightArrow)){
			jim.SetBool ("idle", false);
			jim.SetBool ("LeftKey", true);
			rb2d.velocity = right;
		} else {
			jim.SetBool ("LeftKey", false);
			jim.SetBool ("idle", true);
			rb2d.velocity = noMove;
		}
		if (Input.GetKey(KeyCode.LeftArrow)){
			jim.SetBool ("idle", false);
			jim.SetBool ("RightKey", true);
			rb2d.velocity = left;
		} else {
			jim.SetBool ("RightKey", false);
			jim.SetBool ("idle", true);
			rb2d.velocity = noMove;
		}
	}

}
