using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {
	public string name;
	public Famvas canvas;
	// Use this for initialization
	public void AHHH () {
		GameObject Fr1 = GameObject.Instantiate ((GameObject)Resources.Load (name));;
		GameObject g = GameObject.FindGameObjectWithTag ("canvas");
		canvas = g.GetComponent<Famvas> ();
		canvas.turnOff = false;
	}
}
