using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(Input.GetAxis("Horizontal"));
        float zRotation = transform.localEulerAngles.z;
        zRotation = zRotation - Input.GetAxis("Horizontal");
        transform.localEulerAngles = new Vector3(10, 0, zRotation);

        if(Input.touchCount > 0 || Input.GetMouseButton(0)) //0번째 마우스버튼 왼쪽 버튼
        {
            Debug.Log("mouse down" + Input.mousePosition);
            if(Input.mousePosition.x < Screen.width / 2)    // 모바일에선 터치가 mousePosition임
            {// 왼쪽을 클릭한 경우
                transform.localEulerAngles = new Vector3(10
                    , 0
                    , transform.localEulerAngles.z + 1);
            } else
            {// 오른쪽 클릭한 경우
                transform.localEulerAngles = new Vector3(10
                    , 0
                    , transform.localEulerAngles.z - 1);
            }
        }
	}
}
