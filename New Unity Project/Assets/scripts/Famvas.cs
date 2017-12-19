using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Famvas : MonoBehaviour {
	public bool turnOff = false;
	public Canvas rhee;
	public void Start(){
		rhee = gameObject.GetComponent<Canvas> ();
	}
	public void Update(){
		if (turnOff == true) {
			rhee.renderMode = RenderMode.WorldSpace;
		} else if (turnOff == false) {
			rhee.renderMode = RenderMode.ScreenSpaceOverlay;
		}
	}
}
