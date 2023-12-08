using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sp2 : MonoBehaviour
{
    [SerializeField] private float SpawnRate = 1f;
    [SerializeField] private GameObject[] enemyPrefabs;
    [SerializeField] private bool canSpawn = true;


    void Start()
    {
        StartCoroutine(Spawner());
    }
    private IEnumerator Spawner()
    {
        WaitForSeconds wait = new WaitForSeconds(SpawnRate);
        while (canSpawn)
        {
            yield return wait;
            int rand = Random.Range(0, enemyPrefabs.Length);
            GameObject enemyToSpawn = enemyPrefabs[rand];
            Instantiate(enemyToSpawn, transform.position, Quaternion.identity);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
