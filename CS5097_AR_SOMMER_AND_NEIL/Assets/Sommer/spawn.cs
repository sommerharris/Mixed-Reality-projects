using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject enemy;
    public float xPos;
    public float zPos;

    public float enemyCount;

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop() 
    {
        while (enemyCount < 3)
        {
            xPos = Random.Range(-2.4f, 3.4f);
            zPos = Random.Range(3, 8);
            Instantiate(enemy, new Vector3(xPos, .05f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(.3f);
            enemyCount += 1;
        }
    }
}