using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject pipePrefab;

    [SerializeField]
    private float minSpawnDelay = 1.5f;
    [SerializeField]
    private float maxSpawnDelay = 3f;
    
    [SerializeField]
    private float verticalSpawnRange = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeSpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void InvokeSpawnPipe()
    {
        float spawnDelay = Random.Range(minSpawnDelay, maxSpawnDelay);
        Invoke(nameof(SpawnPipe), spawnDelay);
    }

    private void SpawnPipe()
    {
        Vector2 spawnOffset = new Vector2();
        spawnOffset.y = Random.Range(verticalSpawnRange, -verticalSpawnRange);

        Instantiate(pipePrefab, (Vector2) transform.position + spawnOffset, transform.rotation);

        InvokeSpawnPipe();
    }
}
