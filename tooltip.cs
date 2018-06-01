using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tooltip : MonoBehaviour
{
	private item item = new item ();
	private item2 item2 = new item2 ();

	private GameObject Tooltip;
	private Vector2 left = new Vector2 (-0.3f, 0.5f);
	private Vector2 right = new Vector2 (1.2f, 0.5f);
	private string data;
	public int i,c;

	// Use this for initialization
	void Start ()
	{
		Tooltip = GameObject.Find ("Tooltip");
		Tooltip.SetActive (false);

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Tooltip.activeSelf) {
			Tooltip.transform.position = Input.mousePosition;
		}
	}

	public void nothide ()
	{
		if (i != 0 && c == 1) {
			item.nayong (i);
			COnstructDataString ();
			Tooltip.SetActive (true);
		} else if(i != 0 && c ==2){
			item2.nayong (i);
			COnstructDataString ();
			Tooltip.SetActive (true);
		}
			
	}

	public void hide ()
	{
		Tooltip.SetActive (false);
	}

	public void COnstructDataString ()
	{
		if (c == 1) {
			data = "<color=#0473f0><b>" + item.title + "</b></color>\n\n" + item.explanation;
			Tooltip.transform.GetChild (0).GetComponent<Text> ().text = data;
		} else {
			data = "<color=#0473f0><b>" + item2.title + "</b></color>\n\n" + item2.explanation;
			Tooltip.transform.GetChild (0).GetComponent<Text> ().text = data;
		}
	}

	public void button1 ()
	{
		gameObject.GetComponent<RectTransform> ().pivot = left;
		//i = data.data [0];
		i = slotpanel.data [0];
		c = 1;

	}

	public void button2 ()
	{
		gameObject.GetComponent<RectTransform> ().pivot = left;
		i = slotpanel.data [1];
		c = 1;
	}

	public void button3 ()
	{
		gameObject.GetComponent<RectTransform> ().pivot = left;
		i = slotpanel.data [2];
		c = 1;
	}

	public void button4 ()
	{
		i = slotpanel.data [3];
		gameObject.GetComponent<RectTransform> ().pivot = left;
		c = 1;
	}

	public void button5 ()
	{
		gameObject.GetComponent<RectTransform> ().pivot = left;
		i = slotpanel.data [4];
		c = 1;
	}

	public void button6 ()
	{
		gameObject.GetComponent<RectTransform> ().pivot = left;
		i = slotpanel.data [5];
		c = 1;
	}

	public void button7 ()
	{
		gameObject.GetComponent<RectTransform> ().pivot = left;
		i =slotpanel.data [6];
		c = 1;
	}

	public void button8 ()
	{
		gameObject.GetComponent<RectTransform> ().pivot = right;
		i = slotpanel.data [7];
		c = 1;
	}

	public void button9 ()
	{
		gameObject.GetComponent<RectTransform> ().pivot = right;
		i = slotpanel.data [8];
		c = 1;
	}

	public void button01 ()
	{
		gameObject.GetComponent<RectTransform> ().pivot = left;
		//i = data.data [0];
		i = slotpanel.data2 [0];
		c = 2;
	}

	public void button02 ()
	{
		gameObject.GetComponent<RectTransform> ().pivot = left;
		i = slotpanel.data2 [1];
		c = 2;
	}

	public void button03 ()
	{
		gameObject.GetComponent<RectTransform> ().pivot = left;
		i = slotpanel.data2 [2];
		c = 2;
	}

	public void button04 ()
	{
		i = slotpanel.data2 [3];
		gameObject.GetComponent<RectTransform> ().pivot = left;
		c = 2;
	}

	public void button05 ()
	{
		gameObject.GetComponent<RectTransform> ().pivot = left;
		i = slotpanel.data2 [4];
		c = 2;
	}

	public void button06 ()
	{
		gameObject.GetComponent<RectTransform> ().pivot = left;
		i = slotpanel.data2 [5];
		c = 2;
	}

	public void button07 ()
	{
		gameObject.GetComponent<RectTransform> ().pivot = left;
		i =slotpanel.data2 [6];
		c = 2;
	}

	public void button08 ()
	{
		gameObject.GetComponent<RectTransform> ().pivot = right;
		i = slotpanel.data2 [7];
		c = 2;
	}

	public void button09 ()
	{
		gameObject.GetComponent<RectTransform> ().pivot = right;
		i = slotpanel.data2 [8];
		c = 2;
	}

}
