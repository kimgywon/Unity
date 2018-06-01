using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ChangeDoor : MonoBehaviour
{
	// Use this for initialization
	//마우스 포인터로 사용할 텍스처를 입력받습니다.
	public Texture2D cursorTexture;
	//마우스 포인터로 사용할 텍스처를 입력받습니다.
	public Texture2D basecursorTexture;
	//내부에서 사용할 필드를 선업합니다.
	private Vector2 hotSpot = Vector2.zero;
	public RaycastHit hit;
	public GameObject camera1;
	public GameObject camera2;


    //private bool bIsLoadMain = true;

	//텍스처의 중심을 마우스의 좌표로 사용하는 경우
	//텍스처의 폭과 높이의 1/2을 hot Spot 좌표로 입력합니다.

	void Start ()
	{
		Cursor.SetCursor (basecursorTexture, hotSpot, CursorMode.Auto);

        if (push.open == 1) {
			//camera1.transform.position = deskscencs.vector;
		} else if (push.open == 2) {
			camera1.transform.position = deskscencs.vector;
		}
    }

	// Update is called once per frame
	void Update ()
	{       
        Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
        //마우스를 누를때 실행 0왼쪽,1오른쪽,2휠
        //Ray ray = new Ray (transform.position, transform.forward);// 무한한 선 그리기 position(원점),forward(z축방향)

       test (ray, 1.3f);
       test2 (ray, 1.3f);  
    }

	void mousecheang ()
	{
		Cursor.SetCursor (cursorTexture, hotSpot, CursorMode.Auto);
        //Debug.Log("mousecheang1");
    }

	void mousecheang2 ()
	{
		Cursor.SetCursor (basecursorTexture, hotSpot, CursorMode.Auto);
       // Debug.Log("mousecheang2");
    }

	void test (Ray ray, float interactDistance)
	{
		if (!EventSystem.current.IsPointerOverGameObject ())
        {
			if (Physics.Raycast (ray, out hit, interactDistance))
            {
				if (hit.collider.CompareTag ("Door") || hit.collider.CompareTag ("Door2")) {
					if (Input.GetKeyDown (KeyCode.Mouse0)) {
						hit.collider.transform.parent.GetComponent<doorOPen> ().ChangeDoorState ();
					}
				} else if (hit.collider.CompareTag ("desk")) {
					if (Input.GetKeyDown (KeyCode.Mouse0)) {
						hit.collider.transform.parent.GetComponent<deskopen> ().ChangedeskState ();
					}
				}
                else if (hit.collider.CompareTag ("desk2") && push.open == 0)
                {
					if (Input.GetKeyDown (KeyCode.Mouse0))
                    {
						hit.collider.transform.parent.GetComponent<deskscencs> ().Changedesk1State ();
					}
				}
                else if (hit.collider.CompareTag ("desk2") && push.open == 2)
                {
					if (Input.GetKeyDown (KeyCode.Mouse0))
                    {
						hit.collider.transform.parent.GetComponent<deskscencs> ().Changedesk1State ();
					}
				}
                
                else if (hit.collider.CompareTag ("desk2") && push.open == 1) {
					if (Input.GetKeyDown (KeyCode.Mouse0)) {
						hit.collider.transform.parent.GetComponent<deskopen> ().ChangedeskState ();
					}
				} else
					Invoke ("mousecheang2", 0.01f);
			}     
		}
			Invoke ("mousecheang2", 0.01f);
	}

	void test2 (Ray ray, float interactDistance)
	{
		if (!EventSystem.current.IsPointerOverGameObject ())
        {
			if (Physics.Raycast (ray, out hit, interactDistance))
            {
				if (hit.collider.CompareTag ("Door") || hit.collider.CompareTag ("Door2"))
                {
					Invoke ("mousecheang", 0.01f);
				}

                else if (hit.collider.CompareTag ("desk")) {
					Invoke ("mousecheang", 0.01f);
				}

                else if (hit.collider.CompareTag ("desk2")) {
					Invoke ("mousecheang", 0.01f);
				}

                else if (hit.collider.CompareTag ("1")) {
					Invoke ("mousecheang", 0.01f);
				}
            //    else
			//		Invoke ("mousecheang2", 0.01f);
			}
		}
         
		 // Invoke ("mousecheang2", 0.01f);
	}

}
