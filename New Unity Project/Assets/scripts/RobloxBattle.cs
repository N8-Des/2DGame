using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobloxBattle : Boss {
	public IEnumerator summonOOF;
	public IEnumerator SummonLogo1;
	public IEnumerator robloxLaser;
	public IEnumerator SummonLogo2;
	public int times;
	public int times2;

	public void Start(){
		summonOOF = wall ();
		StartCoroutine (summonOOF);

	}
	public IEnumerator wall(){
		GameObject OOF = GameObject.Instantiate ((GameObject)Resources.Load ("OOF Wall"));;
		times += 1;
		yield return new WaitForSeconds (1.4f);
		SummonLogo1 = roblix1 ();
		if (times >= 6) {
			robloxLaser = laser ();
			StartCoroutine (robloxLaser);
		}
		if (times < 6) {
			StartCoroutine (SummonLogo1);
		}
	}
	public IEnumerator roblix1(){
		Vector3 offset = new Vector3 (Random.Range(-9f, 9f), 0, 0);
		Vector3 offset2 = new Vector3 (Random.Range(-9f, 9f), 0, 0);
		Vector3 offset3= new Vector3 (Random.Range(-9f, 9f), 0, 0);
		Vector3 offset4 = new Vector3 (Random.Range(-9f, 9f), 0, 0);
		Vector3 offset5 = new Vector3 (Random.Range(-9f, 9f), 0, 0);
		GameObject log = GameObject.Instantiate ((GameObject)Resources.Load ("RobloxLogo"));;
		log.transform.position = this.transform.position + offset;
		GameObject log2 = GameObject.Instantiate ((GameObject)Resources.Load ("RobloxLogo"));;
		log2.transform.position = this.transform.position + offset2;
		GameObject log3 = GameObject.Instantiate ((GameObject)Resources.Load ("RobloxLogo"));;
		log3.transform.position = this.transform.position + offset3;
		GameObject log4 = GameObject.Instantiate ((GameObject)Resources.Load ("RobloxLogo"));;
		log4.transform.position = this.transform.position + offset4;
		GameObject log5 = GameObject.Instantiate ((GameObject)Resources.Load ("RobloxLogo"));;
		log5.transform.position = this.transform.position + offset5;
		yield return new WaitForSeconds (2);
		succme ();
	}
	void succme(){
		summonOOF = wall ();
		StartCoroutine (summonOOF);
	}
	public IEnumerator laser(){
		Vector3 offset = new Vector3 (Random.Range(-9f, 9f), Random.Range(-9f, 9f), 0);
		Vector3 offset2 = new Vector3 (Random.Range(-9f, 9f), Random.Range(-9f, 9f), 0);
		Vector3 offset3= new Vector3 (Random.Range(-9f, 9f), Random.Range(-9f, 9f), 0);
		Vector3 offsetl = new Vector3 (Random.Range(-9f, 9f), 0, 0);
		GameObject robu = GameObject.Instantiate ((GameObject)Resources.Load ("Robux"));;
		robu.transform.position = this.transform.position + offsetl;
		GameObject log = GameObject.Instantiate ((GameObject)Resources.Load ("RobloxLogo"));;
		log.transform.position = this.transform.position + offset;
		GameObject log2 = GameObject.Instantiate ((GameObject)Resources.Load ("RobloxLogo"));;
		log2.transform.position = this.transform.position + offset2;
		GameObject log3 = GameObject.Instantiate ((GameObject)Resources.Load ("RobloxLogo"));;
		times2 += 1;
		yield return new WaitForSeconds (2);
		SummonLogo2 = roblix2 ();
		StartCoroutine (SummonLogo2);
	}
	public IEnumerator roblix2(){	
		Vector3 offset = new Vector3 (Random.Range(-9f, 9f), Random.Range(-9f, 9f), 0);
		Vector3 offset2 = new Vector3 (Random.Range(-9f, 9f), Random.Range(-9f, 9f), 0);
		Vector3 offset3= new Vector3 (Random.Range(-9f, 9f), Random.Range(-9f, 9f), 0);
		Vector3 offset4 = new Vector3 (Random.Range(-9f, 9f), Random.Range(-9f, 9f), 0);
		Vector3 offset5 = new Vector3 (Random.Range(-9f, 9f), Random.Range(-9f, 9f), 0);
		GameObject log = GameObject.Instantiate ((GameObject)Resources.Load ("RobloxLogo"));;
		log.transform.position = this.transform.position + offset;
		GameObject log2 = GameObject.Instantiate ((GameObject)Resources.Load ("RobloxLogo"));;
		log2.transform.position = this.transform.position + offset2;
		GameObject log3 = GameObject.Instantiate ((GameObject)Resources.Load ("RobloxLogo"));;
		log3.transform.position = this.transform.position + offset3;
		GameObject log4 = GameObject.Instantiate ((GameObject)Resources.Load ("RobloxLogo"));;
		log4.transform.position = this.transform.position + offset4;
		GameObject log5 = GameObject.Instantiate ((GameObject)Resources.Load ("RobloxLogo"));;
		log5.transform.position = this.transform.position + offset5;
		yield return new WaitForSeconds (2);
		robloxLaser = laser ();
		StartCoroutine (robloxLaser);
	}
}