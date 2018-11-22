using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorMovement : MonoBehaviour {

	RaycastHit hit;
	
	Ray ray;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		if (Physics.Raycast(ray,out hit))
		{
				//Debug.Log(hit.collider.name);
				this.transform.position = hit.collider.transform.position;
		}
		
	}
}
