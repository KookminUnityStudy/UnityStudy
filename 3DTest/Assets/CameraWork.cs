using UnityEngine;
using System.Collections;

public class CameraWork : MonoBehaviour {
    public GameObject ball; // inspector상에서 추가해주면 script 상에서 초기화 할 필요 없음
	// Use this for initialization
	void Start () {
        //ball = GameObject.Find("Ball"); // inspector 상의 추가햇음
        /*
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");

        for(int i=0; i<coins.Length; i++)
            Debug.Log(coins[i].name);
        */
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("I am Camera. And ball is at " + ball.transform.position.z);
        transform.position = new Vector3(0
            , ball.transform.position.y + 3
            , ball.transform.position.z - 14); 
	}
}
