using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnController : MonoBehaviour
{
    public float spawnRange = 5;
    public float spawnLocation = 10;
    public GameObject obstacle;

    [Header("timer")]
    public float spawnTime = 2;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = spawnTime;        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            timer = spawnTime;
            var height = Random.Range(-spawnRange, spawnRange);
            GameObject.Instantiate(obstacle, new Vector3(spawnLocation, height, 0), Quaternion.identity);
        }        
    }
}
