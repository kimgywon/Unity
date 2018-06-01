using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{

	public string title;
	public string explanation;

	public int i;


	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	public void nayong (int i)
	{
		
		switch (i) {
		case 0:
			title = "";
			explanation = "";
			break;
		case 1:
			title = "편지 1";
			explanation = "문제가 적혀있다";
			break;
		case 2:
			title = "편지 2";
			explanation = "문제가 적혀있다";
			break;
		case 3:
			title = "편지 3";
			explanation = "문제가 적혀있다";
			break;
		case 4:
			title = "편지 4";
			explanation = "문제가 적혀있다";
			break;
		case 5:
			title = "시간 +";
			explanation = "시간 + 5분";
			break;
		case 6:
			title = "시간 +";
			explanation = "시간 + 3분";
			break;
		case 7:
			title = "투명 벽 보기";
			explanation = "시간 : 10초\n주의 사용시간이 \n끝나면 사용하세요";
			break;
		}
	}
		
}
