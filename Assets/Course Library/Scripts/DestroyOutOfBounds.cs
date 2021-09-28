using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30f;
    private float lowerBound = -10f;
    private float sideLBound = -30f;
    private float sideRBound = 20f;
    private GameManager gameManager;


    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound) 
        {
            //gameManager.AddLives(-1);
            Destroy(gameObject);

        } else if (transform.position.x < sideLBound) 
        {
            //gameManager.AddLives(-1);
            Destroy(gameObject);

        } else if (transform.position.x > sideRBound) 
        {
            //gameManager.AddLives(-1);
            Destroy(gameObject);

        } else if (transform.position.z < lowerBound) 
        {
            //gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
