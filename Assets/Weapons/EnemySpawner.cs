using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] float xPositionMin = 34f;
    [SerializeField] float xPositionMax = 80f;
    [SerializeField] float yPosition = 50f;
    [SerializeField] float zPositionMin = 18f;
    [SerializeField] float zPositionMax = 50f;
    [SerializeField] float secondsToRespawnEnemy = 5f;

    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        while(true)
        {
        float xPosition = Random.Range(xPositionMin, xPositionMax);
        float zPosition = Random.Range(zPositionMin, zPositionMax);
        Instantiate(enemy, new Vector3(xPosition, yPosition, zPosition), Quaternion.identity);
        yield return new WaitForSecondsRealtime(secondsToRespawnEnemy);
        }
    }
}
