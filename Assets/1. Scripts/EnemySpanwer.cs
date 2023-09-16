using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpanwer : MonoBehaviour
{
    [SerializeField] private StageData stageData;
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] float spawnTime = 0.35f;
    private Coroutine spawnEnemy;

    void Awake()
    {
        spawnEnemy = StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            float randomPositionX = Random.Range(stageData.LimitMin.x, stageData.LimitMax.x);

            Instantiate(enemyPrefab, new Vector3(randomPositionX, stageData.LimitMax.y + 1.0f, 0), Quaternion.identity);

            yield return new WaitForSeconds(spawnTime);
        }
    }
}
