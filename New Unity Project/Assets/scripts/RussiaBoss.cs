using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RussiaBoss : Boss {
	public IEnumerator cyka;
	public IEnumerator sickle;
	public IEnumerator vodka;
	public int times;
	public void Start(){
		sickle = sik();
		StartCoroutine (sickle);
	}
	public IEnumerator sik(){
		times += 1;
		GameObject Lcom = GameObject.Instantiate ((GameObject)Resources.Load ("commyL"));;
		GameObject Rcom = GameObject.Instantiate ((GameObject)Resources.Load ("commyR"));;
		yield return new WaitForSeconds (2);
		cyka = suka();
		if (times >= 8){
			GameObject america = GameObject.Instantiate ((GameObject)Resources.Load ("merica"));;
			america.transform.position = this.transform.position;
			Destroy (this.gameObject);
		}
		StartCoroutine (cyka);
	}
	public IEnumerator suka(){
		GameObject blat = GameObject.Instantiate ((GameObject)Resources.Load ("blat"));;
		yield return new WaitForSeconds (1.5f);
		sickle = sik();
		StartCoroutine (sickle);
	}
}
