using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetBoss : Boss {
	public float wait1;
	public IEnumerator list;
	public int times;
	public int times2;
	public int timesa;
	public void FixedUpdate(){
		wait1 += Time.deltaTime;
		if(wait1 >= 0.3){
			wait1 = 0;
			Vector3 offset = new Vector3 (Random.Range(-10f, 10f), 7, 0);
			times += 1;
			timesa += 1;
			GameObject net = GameObject.Instantiate ((GameObject)Resources.Load ("MoneyBomb"));;
			net.transform.position = this.transform.position + offset;
			if (timesa >= 25){
				timesa = 0;
				GameObject atat = GameObject.Instantiate ((GameObject)Resources.Load ("att1"));;
				GameObject atat2 = GameObject.Instantiate ((GameObject)Resources.Load ("att2"));;

			}
			if (times >= 20) {
				times = 0;
				Vector3 offset2 = new Vector3 (Random.Range(-8f, 8f), 0, 0);
				GameObject indi = GameObject.Instantiate ((GameObject)Resources.Load ("danger"));;
				indi.transform.position = this.transform.position + offset2;		
				times2 += 1;
			}
		}
	}
}
