using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject LoopingObjectPrefab;
    private Vector3 spawnLocation = new Vector3(25, 0, 0);
    private float initalWait = 2;
    private float periodRepeat = 2;
    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", initalWait, periodRepeat);
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();

        int LoopingBarrel = 20;
        float LoopingWidth = GameObject.Find("Background").GetComponent<BoxCollider>().size.x;
        float spacing = LoopingWidth / LoopingBarrel;

        for (int count = 0; count < LoopingBarrel; count++)
        {
            Debug.Log(count * spacing);
            Instantiate(LoopingObjectPrefab, new Vector3(count * spacing, 0, 3f), LoopingObjectPrefab.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObstacle()
    {
        if (playerController.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnLocation, obstaclePrefab.transform.rotation);
        }
    }
}
