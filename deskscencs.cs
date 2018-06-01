using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deskscencs : MonoBehaviour {
	public bool desk1_open = true;
	public GameObject camera1;
	public GameObject camera2;
	public static Vector3  vector ;

	void start(){


	}
	public void Changedesk1State(){ // 다른 스크립트에서 사용 
		
		desk1_open = !desk1_open;
		
	}

	// Update is called once per frame
	void Update () {
		if (push.open <= 1) {
			if (desk1_open) {
				camera1.SetActive (false);
				vector = camera1.transform.position;
				camera2.SetActive (true);
			} else if (!desk1_open) {	
				camera1.SetActive (true);
				camera2.SetActive (false);
			}
		} else {
			if (desk1_open) {
				camera1.SetActive (true);
				camera2.SetActive (false);
			} else if (!desk1_open) {	
				camera1.SetActive (false);
				camera2.SetActive (true);
			}
		}
			
	}

}