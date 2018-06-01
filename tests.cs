using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tests : MonoBehaviour
{
	public Image panel;
	public Sprite[] letter = new Sprite[4];
	private GameObject letterimage;
	public static bool hide = false;


	// Use this for initialization
	void Start ()
	{
		letterimage = GameObject.Find ("letterimage");
		//letterimage.SetActive (hide);

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (hide == false)
			panel.raycastTarget = false;
		else
			panel.raycastTarget = true;
	}



	public void button1 ()
	{

		if (slotpanel.data [0] > 0 && slotpanel.data [0] < 5) {
			panel.sprite = letter [slotpanel.data [0] - 1];
			hide = !hide;
			letterimage.SetActive (hide);
		} else if (slotpanel.data [0] == 5) {
			Timer.time = Timer.time + 300f;
			slotpanel.data [0] = 0;
			GetComponent<slotpanel> ().Reflash ();
		} 
		else if (slotpanel.data [0] == 6) {
			Timer.time = Timer.time + 180f;
			slotpanel.data [0] = 0;
			GetComponent<slotpanel> ().Reflash ();
		} 
		else if (slotpanel.data [0] == 7) {
			trigger.trigercheck = true;
			slotpanel.data [0] = 0;
			GetComponent<slotpanel> ().Reflash ();
		} 


	}

	public void button2 ()
	{
		if (slotpanel.data [1] > 0 && slotpanel.data [1] < 5) {
			panel.sprite = letter [slotpanel.data [1] - 1];
			hide = !hide;
			letterimage.SetActive (hide);
		} else if (slotpanel.data [1] == 5) {
			Timer.time = Timer.time + 300f;
			slotpanel.data [1] = 0;
			GetComponent<slotpanel> ().Reflash ();
		}
		else if (slotpanel.data [1] == 6) {
			Timer.time = Timer.time + 180f;
			slotpanel.data [1] = 0;
			GetComponent<slotpanel> ().Reflash ();
		} 
		else if (slotpanel.data [1] == 7) {
			trigger.trigercheck = true;
			slotpanel.data [1] = 0;
			GetComponent<slotpanel> ().Reflash ();
		} 


	}

	public void button3 ()
	{
		if (slotpanel.data [2] > 0 && slotpanel.data [2] < 5) {
			panel.sprite = letter [slotpanel.data [2] - 1];
			hide = !hide;
			letterimage.SetActive (hide);
		} else if (slotpanel.data [2] == 5) {
			Timer.time = Timer.time + 300f;
			slotpanel.data [2] = 0;
			GetComponent<slotpanel> ().Reflash ();
		}
		else if (slotpanel.data [2] == 6) {
			Timer.time = Timer.time + 180f;
			slotpanel.data [2] = 0;
			GetComponent<slotpanel> ().Reflash ();
		} 
		else if (slotpanel.data [2] == 7) {
			trigger.trigercheck  = true;
			slotpanel.data [2] = 0;
			GetComponent<slotpanel> ().Reflash ();
		} 

	}

	public void button4 ()
	{
		if (slotpanel.data [3] > 0 && slotpanel.data [3] < 5) {
			panel.sprite = letter [slotpanel.data [3] - 1];
			hide = !hide;
			letterimage.SetActive (hide);
		} else if (slotpanel.data [3] == 5) {
			Timer.time = Timer.time + 300f;
			slotpanel.data [3] = 0;
			GetComponent<slotpanel> ().Reflash ();
		}
		else if (slotpanel.data [3] == 6) {
			Timer.time = Timer.time + 180f;
			slotpanel.data [3] = 0;
			GetComponent<slotpanel> ().Reflash ();
		} 
		else if (slotpanel.data [3] == 7) {
			trigger.trigercheck  = true;
			slotpanel.data [3] = 0;
			GetComponent<slotpanel> ().Reflash ();
		} 

	}

	public void button5 ()
	{
		if (slotpanel.data [4] > 0 && slotpanel.data [4] < 5) {
			panel.sprite = letter [slotpanel.data [4] - 1];
			hide = !hide;
			letterimage.SetActive (hide);
		} else if (slotpanel.data [4] == 5) {
			Timer.time = Timer.time + 300f;
			slotpanel.data [4] = 0;
			GetComponent<slotpanel> ().Reflash ();
		}
		else if (slotpanel.data [4] == 6) {
			Timer.time = Timer.time + 180f;
			slotpanel.data [4] = 0;
			GetComponent<slotpanel> ().Reflash ();
		} 
		else if (slotpanel.data [4] == 7) {
			trigger.trigercheck  = true;
			slotpanel.data [4] = 0;
			GetComponent<slotpanel> ().Reflash ();
		} 

	}

	public void button6 ()
	{
		if (slotpanel.data [5] > 0 && slotpanel.data [5] < 5) {
			panel.sprite = letter [slotpanel.data [5] - 1];
			hide = !hide;
			letterimage.SetActive (hide);
		} else if (slotpanel.data [5] == 5) {
			Timer.time = Timer.time + 300f;
			slotpanel.data [5] = 0;
			GetComponent<slotpanel> ().Reflash ();
		}
		else if (slotpanel.data [5] == 6) {
			Timer.time = Timer.time + 180f;
			slotpanel.data [5] = 0;
			GetComponent<slotpanel> ().Reflash ();
		} 
		else if (slotpanel.data [5] == 7) {
			trigger.trigercheck  = true;
			slotpanel.data [5] = 0;
			GetComponent<slotpanel> ().Reflash ();
		} 

	}

	public void button7 ()
	{
		if (slotpanel.data [6] > 0 && slotpanel.data [6] < 5) {
			panel.sprite = letter [slotpanel.data [6] - 1];
			hide = !hide;
			letterimage.SetActive (hide);
		} else if (slotpanel.data [6] == 5) {
			Timer.time = Timer.time + 300f;
			slotpanel.data [6] = 0;
			GetComponent<slotpanel> ().Reflash ();
		}
		else if (slotpanel.data [6] == 6) {
			Timer.time = Timer.time + 180f;
			slotpanel.data [6] = 0;
			GetComponent<slotpanel> ().Reflash ();
		} 
		else if (slotpanel.data [6] == 7) {
			trigger.trigercheck= true;
			slotpanel.data [6] = 0;
			GetComponent<slotpanel> ().Reflash ();
		} 

	}

	public void button8 ()
	{
		if (slotpanel.data [7] > 0 && slotpanel.data [7] < 5) {
			panel.sprite = letter [slotpanel.data [7] - 1];
			hide = !hide;
			letterimage.SetActive (hide);
		} else if (slotpanel.data [7] == 5) {
			Timer.time = Timer.time + 300f;
			slotpanel.data [7] = 0;
			GetComponent<slotpanel> ().Reflash ();
		}
		else if (slotpanel.data [7] == 6) {
			Timer.time = Timer.time + 180f;
			slotpanel.data [7] = 0;
			GetComponent<slotpanel> ().Reflash ();
		} 
		else if (slotpanel.data [7] == 7) {
			trigger.trigercheck = true;
			slotpanel.data [7] = 0;
			GetComponent<slotpanel> ().Reflash ();
		} 

	}

	public void button9 ()
	{
		if (slotpanel.data [8] > 0 && slotpanel.data [8] < 5) {
			panel.sprite = letter [slotpanel.data [8] - 1];
			hide = !hide;
			letterimage.SetActive (hide);
		} else if (slotpanel.data [8] == 5) {
			Timer.time = Timer.time + 300f;
			slotpanel.data [8] = 0;
			GetComponent<slotpanel> ().Reflash ();
		}
		else if (slotpanel.data [8] == 6) {
			Timer.time = Timer.time + 180f;
			slotpanel.data [8] = 0;
			GetComponent<slotpanel> ().Reflash ();
		} 
		else if (slotpanel.data [8] == 7) {
			trigger.trigercheck= true;
			slotpanel.data [8] = 0;
			GetComponent<slotpanel> ().Reflash ();
		} 

	}

	public void button01 ()
	{

		if (slotpanel.data2 [0] > 0 && slotpanel.data2 [0] < 5) {
			panel.sprite = letter [slotpanel.data2 [0] - 1];
			hide = !hide;
			letterimage.SetActive (hide);
		}
	}

	public void button02 ()
	{

		if (slotpanel.data2 [1] > 0 && slotpanel.data2 [1] < 5) {
			panel.sprite = letter [slotpanel.data2 [1] - 1];
			hide = !hide;
			letterimage.SetActive (hide);
		}
	}

	public void button03 ()
	{

		if (slotpanel.data2 [2] > 0 && slotpanel.data2 [2] < 5) {
			panel.sprite = letter [slotpanel.data2 [2] - 1];
			hide = !hide;
			letterimage.SetActive (hide);
		}
	}

	public void button04 ()
	{

		if (slotpanel.data2 [3] > 0 && slotpanel.data2 [3] < 5) {
			panel.sprite = letter [slotpanel.data2 [3] - 1];
			hide = !hide;
			letterimage.SetActive (hide);
		}
	}

	public void button05 ()
	{


		if (slotpanel.data2 [4] > 0 && slotpanel.data2 [4] < 5) {
			panel.sprite = letter [slotpanel.data2 [4] - 1];
			hide = !hide;
			letterimage.SetActive (hide);
		}
	}

	public void button06 ()
	{

		if (slotpanel.data2 [5] > 0 && slotpanel.data2 [5] < 5) {
			panel.sprite = letter [slotpanel.data2 [5] - 1];
			hide = !hide;
			letterimage.SetActive (hide);
		}
	}

	public void button07 ()
	{

		if (slotpanel.data2 [6] > 0 && slotpanel.data2 [6] < 5) {
			panel.sprite = letter [slotpanel.data2 [6] - 1];
			hide = !hide;
			letterimage.SetActive (hide);
		}
	}

	public void button08 ()
	{

		if (slotpanel.data2 [7] > 0 && slotpanel.data2 [7] < 5) {
			panel.sprite = letter [slotpanel.data2 [7] - 1];
			hide = !hide;
			letterimage.SetActive (hide);
		}
	}

	public void button09 ()
	{

		if (slotpanel.data2 [8] > 0 && slotpanel.data2 [8] < 5) {
			panel.sprite = letter [slotpanel.data2 [8] - 1];
			hide = !hide;
			letterimage.SetActive (hide);
		}
	}
}
