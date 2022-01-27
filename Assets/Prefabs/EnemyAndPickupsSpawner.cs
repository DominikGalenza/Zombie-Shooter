using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAndPickupsSpawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject[] pickups;
    [SerializeField] float xPositionMin = 34f;
    [SerializeField] float xPositionMax = 80f;
    [SerializeField] float yPosition = 50f;
    [SerializeField] float zPositionMin = 18f;
    [SerializeField] float zPositionMax = 50f;
    [SerializeField] float secondsToRespawnEnemy = 5f;
    [SerializeField] float secondsToRespawnPickup = 5f;

    void Start()
    {
        StartCoroutine(SpawnEnemy());
        StartCoroutine(SpawnPickup());
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

    IEnumerator SpawnPickup()
    {
        while(true)
        {
            float xPosition = Random.Range(xPositionMin, xPositionMax);
            float zPosition = Random.Range(zPositionMin, zPositionMax);
            GameObject selectedPickup = pickups[Random.Range(0, pickups.Length)];
            Instantiate(selectedPickup, new Vector3(xPosition, yPosition, zPosition), Quaternion.identity);
            yield return new WaitForSecondsRealtime(secondsToRespawnPickup);
        }
    }
}
