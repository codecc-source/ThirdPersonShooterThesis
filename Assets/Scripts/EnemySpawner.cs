using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject theEnemy1;
    public GameObject theEnemy2;
    public GameObject Items;
    public int xPos;
    public int zPos;
    public int enemyCount1;
    public int numberofEnemies1;
    public int numberofEnemies2;
    public int enemyCount2;
    public int itemCount;

    void Start()
    {
        ScoringScript.timesReloaded += 1;
        StartCoroutine(EnemyDrop1());
        StartCoroutine(EnemyDrop2());
        StartCoroutine(ItemDrop());
    }

    IEnumerator EnemyDrop1()
    {
        while (true)
        {
            numberofEnemies1 = ScoringScript.timesReloaded * 20;
            while (enemyCount1 < numberofEnemies1)
            {
                xPos = Random.Range(10, 140);
                zPos = Random.Range(10, 140);
                Instantiate(theEnemy1, new Vector3(xPos, 3, zPos), Quaternion.identity);
                yield return new WaitForSeconds(0.1f);
                enemyCount1 += 1;
            }
            yield return new WaitForSeconds(2f);
        }
    }

    IEnumerator EnemyDrop2()
    {
        while (true)
        {
            numberofEnemies2 = ScoringScript.timesReloaded * 20;
            while (enemyCount2 < numberofEnemies2)
            {
                xPos = Random.Range(10, 140);
                zPos = Random.Range(10, 140);
                Instantiate(theEnemy2, new Vector3(xPos, 3, zPos), Quaternion.identity);
                yield return new WaitForSeconds(0.1f);
                enemyCount2 += 1;
            }
            yield return new WaitForSeconds(2f);
        }
    }

    IEnumerator ItemDrop()
    {
        while (true)
        {
            itemCount = ScoringScript.timesReloaded * 10;
            while (itemCount > 0)
            {
                xPos = Random.Range(10, 140);
                zPos = Random.Range(10, 140);
                Instantiate(Items, new Vector3(xPos, 1, zPos), Quaternion.identity);
                yield return new WaitForSeconds(0.1f);
                itemCount -= 1;
            }
            yield return new WaitForSeconds(2f);
        }
    }
}
