using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float Speed = 30;
    private PlayerController playerController;
    private float leftBoundary = -15f;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
       if (playerController.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * Speed);
        }

       if(transform.position.x < leftBoundary)
        {
                Destroy(gameObject);
        }
    }
}
