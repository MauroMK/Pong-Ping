using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private GameObject buffPrefab;

    private float leftBorder = -2.3f;
    private float rightBorder = 2.3f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(SpawnEnemy), Random.Range(0.5f, 2f), Random.Range(0.5f, 2f));
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(SpawnEnemy));
    }

    private void SpawnEnemy()
    {
        GameObject enemies = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        enemies.transform.position += Vector3.down * Random.Range(leftBorder, rightBorder);
    }
}
