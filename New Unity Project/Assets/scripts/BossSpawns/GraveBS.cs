﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraveBS : MonoBehaviour {
	public IEnumerator spawnDelay;
	public Famvas canvas;
	public Vector3 offest = new Vector3 (0, 0, -10);
	public void Ah(){
		GameObject g = GameObject.FindGameObjectWithTag ("canvas");
		canvas = g.GetComponent<Famvas> ();
		canvas.turnOff = true;
		GameObject camera = GameObject.FindGameObjectWithTag ("MainCamera");
		camera.transform.position = this.transform.position + offest;
		GameObject player = GameObject.Instantiate ((GameObject)Resources.Load ("Player"));;
		player.transform.position = this.transform.position;
		spawnDelay = spawn ();
		StartCoroutine (spawnDelay);
	}
	public IEnumerator spawn(){
		yield return new WaitForSeconds (2);
		GameObject boss = GameObject.Instantiate ((GameObject)Resources.Load ("Memes"));;

	}
}