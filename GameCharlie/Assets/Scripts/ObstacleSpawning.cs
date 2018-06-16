using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawning : MonoBehaviour {

    public GameObject obstacleH;
    public GameObject obstacleV;
    public GameObject obstacleDL;
    public GameObject obstacleDR;

    bool gameO;

    public float spawnTime = 4f;
    public float elapsedTime = 0f;

    // Use this for initialization
    void Start () {
        gameO = GameController.instance.gameOver;
	}
	
	// Update is called once per frame
	void Update () {
		if(gameO == false)
        {
            if(elapsedTime < spawnTime)
            {
                elapsedTime += Time.deltaTime;
            }
            else
            {
                int spawnNumber = Random.Range(1, 4);

                switch (spawnNumber)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                }
            }
        }
	}
}
