using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robux : MonoBehaviour {
	public IEnumerator Laser;
	// Use this for initialization
	void Start () {
		Laser = fire ();
		StartCoroutine (Laser);
	}
	public IEnumerator fire(){
		yield return new WaitForSeconds (0.2f);
		GameObject log = GameObject.Instantiate ((GameObject)Resources.Load ("Roblaser"));;
		log.transform.position = this.transform.position;
	}
}