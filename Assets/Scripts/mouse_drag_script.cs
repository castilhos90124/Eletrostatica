﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_drag_script : MonoBehaviour {
	
	public float distance;

	private void OnMouseDrag()
	{
		Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
		Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
		transform.position = objPosition;
	}
}

