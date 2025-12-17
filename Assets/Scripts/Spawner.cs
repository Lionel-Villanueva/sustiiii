using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Referencias")]
    public GameObject enemyPrefab;
    public Transform player;

    [Header("Spawn Settings")]
    public float spawndistance = 5f;
    public Vector2[] spawnPostion;
    public int maxEnemies = 10;
    public float spawnInterval = 2f;
    private float spawenTimer = 0f;

    private List<GameObject> spawnedEnemies = new List<GameObject>();
    private void Update()
    {
        spawenTimer += Time.deltaTime;
        if (spawnInterval <= spawenTimer)
        {
            spawenTimer = 0;
            SpawnEnemy();
        }
    }
    private void SpawnEnemy()
    {
        if (spawnedEnemies.Count >= maxEnemies)
            return;

        Vector2 randomPos = spawnPostion[Random.Range(0, spawnPostion.Length)]* spawndistance;
        Vector3 spawnPosition = player.position + new Vector3(randomPos.x,randomPos.y);

        GameObject enemy = Instantiate(enemyPrefab, spawnPosition, transform.rotation);
        enemy.GetComponent<BaseEnemy>().GetTarget(player);
        spawnedEnemies.Add(enemy);
    }

    public void DestroyAllEnemies()
    {
        for(int i = 0; i< spawnedEnemies.Count; ++i)
        {
            if (spawnedEnemies[i] != null)
            {
                Destroy(spawnedEnemies[i]);
            }
        }
        spawnedEnemies.Clear();
    }
}
