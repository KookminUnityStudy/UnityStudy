using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public int coinCount = 0; // 여기서 초기화 된걸로 알 수 없음 (inspector때 바꿀수 잇어서) start때 해주는게 좋음
    public Text coinText;

    void GetCoin()
    {
        coinCount++;
        coinText.text = coinCount + "개";
        Debug.Log("동전: " + coinCount);
    }
    
    public void RestartGame()
    {
        Application.LoadLevel("Game");
    }

    // 만약 10초 후 장애물 다시 살리려면 RedCoin은 사라지니
    // 게임메니저에서 처리해주어야한다. 그래서 필요
    void RedCoinStart()
    {
        DestroyObstacles();
    }

    void DestroyObstacles()
    {
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        for (int i = 0; i < obstacles.Length; i++)
        {
            Destroy(obstacles[i]);
        }
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       // Debug.Log(coinCount);
	}
}
