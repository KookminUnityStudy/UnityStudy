using UnityEngine;
using System.Collections;

public class Stone : MonoBehaviour {

    Vector3 target;

	// Use this for initialization
	void Start () {
        target = GameObject.Find("Ball").transform.position;

	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, target, 0.1f);
        transform.Rotate(new Vector3(0, 0, 5));
	}

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Ball")
        {
            //GameObject.Find("GameManager").SendMessage("RestartGame");
            //GameObject gm = GameObject.Find("GameManager");
            //GameManager gmComponent = gm.GetComponent<GameManager>();
            GameManager gmComponent = GameObject.Find("GameManager").GetComponent<GameManager>();
            gmComponent.RestartGame();
<<<<<<< HEAD
=======
            //sunpark modified
            //2nd modified
            //3rd modified
>>>>>>> refs/remotes/origin/master
        }
    }
}
