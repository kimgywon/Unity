using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changelocksc : MonoBehaviour
{

	// Use this for initialization
	//마우스 포인터로 사용할 텍스처를 입력받습니다.
	public Texture2D cursorTexture;
	//마우스 포인터로 사용할 텍스처를 입력받습니다.
	public Texture2D basecursorTexture;
	//내부에서 사용할 필드를 선업합니다.
	private Vector2 hotSpot = Vector2.zero;
	public RaycastHit hit;


	//텍스처의 중심을 마우스의 좌표로 사용하는 경우
	//텍스처의 폭과 높이의 1/2을 hot Spot 좌표로 입력합니다.

	public void Start ()
	{
		Invoke ("mousecheang2", 0.01f);
	}
	// Update is called once per frame
	void Update ()
	{

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		//마우스를 누를때 실행 0왼쪽,1오른쪽,2휠
		//Ray ray = new Ray (transform.position, transform.forward);// 무한한 선 그리기 position(원점),forward(z축방향)
		test (ray, 2);
		test2 (ray, 2);

	}

	void mousecheang ()
	{		
		Cursor.SetCursor (cursorTexture, hotSpot, CursorMode.Auto);
	}

	void mousecheang2 ()
	{
		Cursor.SetCursor (basecursorTexture, hotSpot, CursorMode.Auto);
	}

	void test (Ray ray, float interactDistance)
	{
		if (Physics.Raycast (ray, out hit, interactDistance)) {
			if (hit.collider.CompareTag ("lock")) {
				if (Input.GetKeyDown (KeyCode.Mouse0)) {
					SceneManager.LoadScene ("lock");
				}
			}

		} else
			Invoke ("mousecheang2", 0.01f);
	}


	void test2 (Ray ray, float interactDistance)
	{
		if (Physics.Raycast (ray, out hit, interactDistance)) {
			if (hit.collider.CompareTag ("lock")) {
				Invoke ("mousecheang", 0.01f);
			} else
				Invoke ("mousecheang2", 0.01f);
		}
	}

}
