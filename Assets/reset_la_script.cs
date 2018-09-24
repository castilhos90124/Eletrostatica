using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class reset_la_script : MonoBehaviour {
	public Button button;
	public GameObject paresCargas;

	public int total;

	void Start () {
		Button btn = button.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);

	}

	void TaskOnClick(){
		
		//paresCargas = GameObject.Find ("ParesCargas");

		//total = 0;
		Transform[] allChildren = paresCargas.GetComponentsInChildren<Transform>(true);

		//Debug.Log ("You have clicked the button!");
		foreach (Transform child in allChildren) {
			//total++;
			if (child.gameObject.activeSelf == false)
				child.gameObject.SetActive (true);
		}

	}

}
