using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class america : Boss {
	public IEnumerator shoot;
	public IEnumerator shoot2;
	public IEnumerator shoot3;
	public int win;
	public void Start(){
		shoot = bang();
		StartCoroutine (shoot);
	}
	public IEnumerator bang(){
		GameObject Rcom = GameObject.Instantiate ((GameObject)Resources.Load ("boom"));;
		shoot2 = bang2();
		yield return new WaitForSeconds (2);
		Vector3 offset = new Vector3 (Random.Range(-2f, 2f), Random.Range(-2f, 2f), 0);
		GameObject trump = GameObject.Instantiate ((GameObject)Resources.Load ("warning"));;
		trump.transform.position = this.transform.position + offset;
		StartCoroutine (shoot2);
	}
	public IEnumerator bang2(){
		GameObject Rcom = GameObject.Instantiate ((GameObject)Resources.Load ("boom2"));;
		shoot = bang();
		win += 1;
		yield return new WaitForSeconds (2);
		Vector3 offset = new Vector3 (Random.Range(-7f, 7f), 0, 0);
		GameObject trump = GameObject.Instantiate ((GameObject)Resources.Load ("warning"));;
		trump.transform.position += offset;
		StartCoroutine (shoot);
		if (win >= 10) {
			ILost = true;
		}
	}

}
