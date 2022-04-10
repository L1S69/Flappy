using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    [SerializeField] private GameObject cloudPrefab;
    [SerializeField] private float spawnDelay;
    [SerializeField] private float cloudSpeed;

    private Transform spawn;

    private void Start()
    {
        spawn = GetComponent<Transform>();
        spawn.position = new Vector3(spawn.position.x, spawn.position.y, 2);
        InvokeRepeating("SpawnCloud", 0f, spawnDelay);
    }

    private void SpawnCloud()
    {
        SetRandomPosition();
        GameObject cloud = Instantiate(cloudPrefab, spawn.position, spawn.rotation);
        cloud.GetComponent<Rigidbody2D>().velocity = new Vector2(-cloudSpeed, 0);

        Destroy(cloud, 9 / cloudSpeed);
    }

    private void SetRandomPosition() 
    {
        float RNDY = Random.Range(-4, 4);
        spawn.position = new Vector3(spawn.position.x, RNDY, 2);
    }
}
