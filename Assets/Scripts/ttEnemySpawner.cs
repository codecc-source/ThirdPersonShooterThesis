using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ttEnemySpawner : MonoBehaviour
{
    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int enemyCount;
    public int numberofEnemies;
    public int maxNumberOfEnemies = 20;

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (true)
        {
            numberofEnemies = maxNumberOfEnemies;
            while (enemyCount < numberofEnemies)
            {
                xPos = Random.Range(10, 140);
                zPos = Random.Range(10, 140);
                Instantiate(theEnemy, new Vector3(xPos, 3, zPos), Quaternion.identity);
                yield return new WaitForSeconds(0.1f);
                enemyCount += 1;
            }
            yield return new WaitForSeconds(2f);
        }
    }
}
