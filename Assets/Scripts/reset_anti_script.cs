using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class reset_anti_script : MonoBehaviour {
	public Button button;
	public GameObject paresCargasAnti;

	public int total;

	void Start () {

		Button btn = button.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);


	}

	void TaskOnClick(){
		
		//paresCargasAnti = GameObject.Find ("ParesCargasAnti");
		total = 0;
		Transform[] allChildren = paresCargasAnti.GetComponentsInChildren<Transform>(true);

		//Debug.Log ("You have clicked the button!");
		foreach (Transform child in allChildren) {
			total++;
			if (child.gameObject.activeSelf == false)
				child.gameObject.SetActive (true);
		}

	}

}
