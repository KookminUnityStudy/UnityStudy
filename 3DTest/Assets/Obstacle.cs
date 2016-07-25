using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
    void TestMethod(string name)
    {
        float distance = Vector3.Distance(GameObject.Find(name).transform.position, transform.position);
        Debug.Log(name+"까지 거리: " + distance);
    }
    // 특정 영역 지나갔다는걸 triger
    void OnCollisionEnter(Collision collision) // 두 물체간의 실제 충돌
    {
        //Debug.Log(collision.gameObject.name);
        Vector3 direction = transform.position - collision.gameObject.transform.position;
        direction = direction.normalized * 1000;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(direction);

    }

    float delta = 0.1f;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //TestMethod("Ground");
        float newXposition = transform.localPosition.x + delta; // 그냥 position은 global 포지션 의미
        transform.localPosition = new Vector3(newXposition
            , transform.localPosition.y
            , transform.localPosition.z);
        if(transform.localPosition.x < -3.5)
        {
            delta = 0.1f;
        } else if(transform.localPosition.x > 3.5)
        {
            delta = -0.1f;
        }
    }
}
