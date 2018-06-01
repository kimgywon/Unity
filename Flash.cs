using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour {
	public GameObject flash;
	public float interval =1f ;
	public bool ch =true;
	private float time;
	// Use this for initialization
	void Start () {
		flash.SetActive (ch);
		time = 0f;
	}
	
	// Update is called once per frame
	void Update () {
	time = time + Time.deltaTime;

		if (time >= interval) {
			time = 0;
			ch = !ch;
			flash.SetActive (ch);
			interval = Random.Range (0.5f, 1f);  
		}
	}
}



