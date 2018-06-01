using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class newba : MonoBehaviour
{
	public slotpanel slot;
	public int number;
	private  bool cheek = true;
	public itemtext item;

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{

	}

	public void OnMouseUp ()
	{
		if (push.open != 1 && push.open !=2) {
			if (cheek) {
				slot.AddItem (0 + number);
				cheek = false;
				item.hide ();
	
			} else {
				item.nothide ();
			}
		}
	
	}


}
