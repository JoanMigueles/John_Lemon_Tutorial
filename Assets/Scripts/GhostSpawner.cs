using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpawner : MonoBehaviour
{
    public GameObject ghostPrefab;
    public Transform spawnPoint;
    public float spawnInterval = 1f;

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnGhost();
            timer = 0f;
        }
    }

    void SpawnGhost()
    {
        GameObject ghost = Instantiate(ghostPrefab, spawnPoint.position, Quaternion.identity);
    }
}