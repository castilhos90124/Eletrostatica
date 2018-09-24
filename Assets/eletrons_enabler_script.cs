using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eletrons_enabler_script : MonoBehaviour {

	//public int total;
	private int eletrons;
	GameObject paresCargas;
	GameObject paresCargasAnti;
	GameObject la;

	active_counter_script active_script;
	//GameObject anti;
	
	// Use this for initialization
	void Start () {
		
		//anti = GameObject.Find("AntiEstatico");
		//paresCargas = GameObject.Find("ParesCargas");
		//paresCargasAnti = GameObject.Find("ParesCargasAnti");
		//Debug.Log(la.activeSelf);
		//Debug.Log(anti.activeSelf);
		//active_script_anti = paresCargasAnti.GetComponent<active_counter_script>();
		//active_script = paresCargas.GetComponent<active_counter_script>();
	}
	
	// Update is called once per frame
	void Update () {
		//total=0;
		la = GameObject.Find("La");



		if (la != null) {
			paresCargas = GameObject.Find ("ParesCargas");
			active_counter_script active_script = paresCargas.GetComponent<active_counter_script> ();
			eletrons = active_script.num_eletrons;
		} 

		else {
			paresCargasAnti = GameObject.Find("ParesCargasAnti");
			active_counter_script active_script = paresCargasAnti.GetComponent<active_counter_script>();
			eletrons = active_script.num_eletrons;
		}



						
		foreach (Transform child in transform)
		{
			if(eletrons > 0){
				if (child.gameObject.activeSelf == false)
					child.gameObject.SetActive(true);
				eletrons --;
			}

			if (eletrons == 0) {
				if (child.gameObject.activeSelf == true)
					child.gameObject.SetActive(false);
			}

			
		}
			



			//Debug.Log(la.activeSelf);
	}
}
