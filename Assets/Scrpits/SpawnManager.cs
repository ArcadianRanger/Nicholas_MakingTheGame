using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnLocation = new Vector3(15, 0, 0);
    private float initalWait = 2;
    private float periodRepeat = 2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawnobstacle", initalWait, periodRepeat);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnLocation, obstaclePrefab.transform.rotation);
    }
}
