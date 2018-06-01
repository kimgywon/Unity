using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class deskopen : MonoBehaviour {
	public bool desk_open = false;
	public float doorOpenAngle;//quaternion 문 회전율 열린상태
	public float doorCloseAngle = 0f; //닫힌상태
	public float smooth = 3f; //회전율 스피드(숫자가 낮을수록 빠름 )
	public static AudioSource audio1;

	// Use this for initialization
	void Start () {
	}

	public void ChangedeskState(){ // 다른 스크립트에서 사용 
		AudioSource audio =  GetComponent<AudioSource>();
		desk_open = !desk_open;
		audio.Play ();
	}

	// Update is called once per frame
	void Update () {
		if (desk_open) {
			Quaternion1 (doorOpenAngle);
		} else if (!desk_open) {
			Quaternion1 (doorCloseAngle);
		} 
	}


	public void Quaternion1(float Angle){
		//Quaternion targetRotaion = Quaternion.Euler (0, Angle, 0);
		Quaternion targetRotaion =  Quaternion.Euler (0f, 0f, Angle);
		//Quaternion = 회전을 표현하기 위해 사용
		//euler = z축 주위로 z, x축 주위로 x, y축 주위로 y 각도만큼 회전한(순서대로) Rotation을 반환합니다.
		transform.localRotation = Quaternion.Slerp (transform.localRotation, targetRotaion, Time.deltaTime * smooth);
		//부모 트랜스폼의 회전에 상대적인, 트랜스폼의 회전을 나타냅니다.(자식만 회저시키기위해서)
		//slerp = from/과 /to/사이를 /t/로 구형보간 합니다.
	}
}