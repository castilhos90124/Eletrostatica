using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class active_counter_script : MonoBehaviour {
	

    private int actives;
    private int total;
	public int num_eletrons;

	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        actives = 0;
        total = 0;
        Transform[] allChildren = GetComponentsInChildren<Transform>(true);
        foreach (Transform child in allChildren)
        {
            total++;

            if (child.gameObject.activeSelf == true)
                actives++;
        }
		num_eletrons = total- actives;
		
	}
}
 
      

