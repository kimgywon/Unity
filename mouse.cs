using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour {

	//마우스 포인터로 사용할 텍스처를 입력받습니다.
	public Texture2D cursorTexture ;
	//마우스 포인터로 사용할 텍스처를 입력받습니다.
	public Texture2D basecursorTexture ;
	//텍스처의 중심을 마우스 좌표로 할 것인지 체크박스로 입력받습니다.
	public bool hotSpotIsCenter = false;
	//내부에서 사용할 필드를 선업합니다.
	private Vector2 hotSpot;

	public void Start(){

	}

	void Update () {
		
		if (hotSpotIsCenter) {
			mouseimage (cursorTexture);
		} else if(!hotSpotIsCenter){
			mouseimage (basecursorTexture);
		}
	

	}
	public void mousechange(){
		hotSpotIsCenter = !hotSpotIsCenter;
	}

	public void mouseimage(Texture2D mouse){
		//텍스처의 중심을 마우스의 좌표로 사용하는 경우
		//텍스처의 폭과 높이의 1/2을 hot Spot 좌표로 입력합니다.
	
		//이제 새로운 마우스 커서를 화면에 표시합니다.
		Cursor.SetCursor (mouse, hotSpot, CursorMode.Auto);
	}
}

