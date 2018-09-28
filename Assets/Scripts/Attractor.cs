
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour {

	const float G = 667.4f;
	public float multiplier;

	public static List<Attractor> Attractors;

	public Rigidbody rb;

	private int eletrons;
	private int CONSTANTE = 20;
	GameObject paresCargas;
	GameObject paresCargasAnti;
	GameObject la;

	void FixedUpdate ()
	{
		foreach (Attractor attractor in Attractors)
		{
			if (attractor != this)
				Attract(attractor);
		}
	}

	void OnEnable ()
	{
		if (Attractors == null)
			Attractors = new List<Attractor>();

		Attractors.Add(this);
	}

	void OnDisable ()
	{
		Attractors.Remove(this);
	}

	void Attract (Attractor objToAttract)
	{
		Rigidbody rbToAttract = objToAttract.rb;

		Vector3 direction = rb.position - rbToAttract.position;
		float distance = direction.magnitude;

		if (distance == 0f)
			return;
		
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

		multiplier = eletrons * CONSTANTE;

		float forceMagnitude =  multiplier * ((rb.mass * rbToAttract.mass) / Mathf.Pow(distance, 2));
		Vector3 force = direction.normalized * forceMagnitude;

		rbToAttract.AddForce(force);
	}

}
