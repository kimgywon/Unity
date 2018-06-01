using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slotpanel : MonoBehaviour
{
	public Image[] slot = new Image [9];
	public Sprite[] item = new Sprite[9];
	public  static int[] data = new int[9];
	public static int[] data2 = new int[9];
	// Use this for initialization
	void Start ()
	{


	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public bool AddItem (int _type)
	{
		for (int i = 0; i < data.Length; i++) {
			if (data [i] != 0)
				continue;
			data [i] = _type;
			Reflash ();
			return true;
		}
		return false;
	}

	public bool AddItem3 ()
	{
		for (int i = 0; i < 8; i++) {
			data [i] = 0;
			Reflash2 ();
		}
		return true;
	}

	public void Reflash ()
	{
		for (int i = 0; i < data.Length; i++)
			slot [i].sprite = item [data [i]];
	}

	public bool AddItem2 (int _type)
	{
		for (int i = 0; i < data2.Length; i++) {
			if (data2 [i] != 0)
				continue;
			data2 [i] = _type;
			Reflash2 ();
			return true;
		}
		return false;
	}

	public void Reflash2 ()
	{
		for (int i = 0; i < data2.Length; i++)
			slot [i].sprite = item [data2 [i]];
	}

}
