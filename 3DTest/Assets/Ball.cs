using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    int count = 1;

    float startingPoint;

    bool shouldPrintOver20 = true;
    bool shuoldPrintOver30 = true;

    //SphereCollider myCollider;

    // Use this for initialization
    // 게임 시작 될때 한번 실행
    void Start () {
        //Debug.Log("일련번호: " + GetInstanceID());

        Rigidbody myRigidbody = GetComponent<Rigidbody>();
        //Debug.Log("UseGravity?:" + myRigidbody.useGravity);
        
        //myCollider = GetComponent<SphereCollider>();

        //Debug.Log("Start");
        //TestMethod();
        startingPoint = transform.position.z;
	}
	
	// Update is called once per frame
    // 프레임마다 실행
    // ex) 유니티에서 공 굴러가는거 매 프레임마다 화면에 보여주는거
	void Update () {
        //int localCount = 1;
        //localCount++;
        //Debug.Log("Update" + count);
        //count = count + 1;
        //Debug.Log(transform.position.z);
        float distance;
        distance = transform.position.z - startingPoint;
        //Debug.Log(distance);
        /*
        if(distance > 30)
        {
            if(shuoldPrintOver30)
            {
                Debug.Log("Over 30:" + distance);
                shuoldPrintOver30 = false;
            }
        } else if (distance > 20)
        {
            if(shouldPrintOver20)
            {
                Debug.Log("Over 20:" + distance);
                shouldPrintOver20 = false;
            }
        } else
        {
            Debug.Log("Less than 20:" + distance);
        }
        */

        //myCollider.radius = myCollider.radius + 0.01f;

        if (Input.GetKeyDown(KeyCode.Space))
            // Input.GetKeyUp 쓰면 떼는 순간
            // Input.GetKey 누르고있는 동안
        {
            //Debug.Log("Space를 눌렀습니다.");
            //GetComponent<Rigidbody>().AddForce(Vector3.up*300);
            Rigidbody ballRigid;
            ballRigid = gameObject.GetComponent<Rigidbody>();
            ballRigid.AddForce(Vector3.up * 300);

            Debug.Log(ballRigid.mass);  // mass 질량
        }
	}

    void TestMethod()
    {
        Debug.Log("This is TestMethod");
    }
}
