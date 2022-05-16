using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    public Transform[] enemySpawnPoints;
    public GameObject enemies;
    public int maxNumberOfEnemies;
    private int numberOfEnemies = 2;

    void Start()
    {
        //SpawnEnemy();
    }

    void Update()
    {

        //SpawnEnemy();
    }

    void OnEnable()
    {
        EnemyAI.OnEnemyDestroyed += SpawnEnemy;
        EnemyAI.OnEnemyDestroyed += EnemyDied;
    }

    void SpawnEnemy()
    {
        if (maxNumberOfEnemies > numberOfEnemies)
        {
            int random = Mathf.RoundToInt(Random.Range(0f, enemySpawnPoints.Length - 1));

            Instantiate(enemies, enemySpawnPoints[random].transform.position, Quaternion.identity);
            numberOfEnemies += 1;
        }
        
    }

    void EnemyDied()
    {
        numberOfEnemies--;
    }

}
