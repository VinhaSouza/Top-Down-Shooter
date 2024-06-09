using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] GameObject[] enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemies", 0.5f, 1f);
    }

    void SpawnEnemies()
    {
        int index = Random.Range(0, spawnPoints.Length);
        int enemyIndex = Random.Range(0, enemy.Length);
        Instantiate(enemy[enemyIndex], spawnPoints[index].position, spawnPoints[index].rotation);
    }

}
