using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappear_script : MonoBehaviour {

//Detect collisions between the GameObjects with Colliders attached

	void OnCollisionEnter(Collision collision)
	{
		
		if (collision.gameObject.name == "Carga Negativa")
		{
			//var parentName = collision.transform.parent.name;
			//var parentName = collision.gameObject.transform.parent.name;
			//Debug.Log(parentName);
			//if(parentName == "Carga Negativa"){
				collision.gameObject.SetActive(false);
				
			//}
		}

	}
	
	
}