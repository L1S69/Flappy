using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] tubePrefab;

    [SerializeField] private float wideTubeYRange;
    [SerializeField] private float middleTubeYRange;
    [SerializeField] private float narrowTubeYRange;
    [SerializeField] private float veryNarrowTubeYRange;

    [SerializeField] private float spawnDelay;
    [SerializeField] private float tubeSpeed;

    private int RND;
    private Transform spawn;

    private void Start()
    {
        spawn = GetComponent<Transform>();
        InvokeRepeating("SpawnTube", 0f, spawnDelay);
    }

    private void SpawnTube() 
    {
        SetRandomSize();
        SetRandomPosition();
        GameObject tube = Instantiate(tubePrefab[RND], spawn.position, spawn.rotation);
        tube.GetComponent<Rigidbody2D>().velocity = new Vector2(-tubeSpeed, 0);

        Destroy(tube, 9/tubeSpeed);
    }

    private void SetRandomSize() 
    {
        RND = Random.Range(0, 3);
    }

    private void SetRandomPosition()
    {
        float RNDY;
        switch (RND)
        { 
            case 0:
                RNDY = Random.Range(-wideTubeYRange, wideTubeYRange);
                spawn.position = new Vector2(spawn.position.x, 0);
                break;
            case 1:
                RNDY = Random.Range(-middleTubeYRange, middleTubeYRange);
                spawn.position = new Vector2(spawn.position.x, RNDY);
                break;
            case 2:
                RNDY = Random.Range(-narrowTubeYRange, narrowTubeYRange);
                spawn.position = new Vector2(spawn.position.x, RNDY);
                break;
            case 3:
                RNDY = Random.Range(-veryNarrowTubeYRange, veryNarrowTubeYRange);
                spawn.position = new Vector2(spawn.position.x, RNDY);
                break;
        }
    }
}
