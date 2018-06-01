using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;



public class solt : MonoBehaviour
{
	GameObject itemsoltpanel;
	GameObject questsoltpanel;
	 bool itemcheek = false;
	 bool questcheek = false;
	public slotpanel slot;
	public slotpanel slot2;

	// Use this for initialization
	void Start ()
	{
		itemsoltpanel = GameObject.Find ("item slot panel");
		itemsoltpanel.SetActive (itemcheek);
		questsoltpanel = GameObject.Find ("quest slot panel");
		questsoltpanel.SetActive (questcheek);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.I)) {
			item ();
			slot.Reflash ();
		} else if (Input.GetKeyDown (KeyCode.Q)) {
			quest ();
			slot2.Reflash2 ();
		}
	}

	public void item ()
	{
		if (!questcheek && !tests.hide) {
			itemcheek = !itemcheek;
			itemsoltpanel.SetActive (itemcheek);
			slot.Reflash ();
		}
	}

	public void quest ()
	{
		if (!itemcheek && !tests.hide) {
			questcheek = !questcheek;
			questsoltpanel.SetActive (questcheek);
			slot2.Reflash2 ();
		}
	}
}
