using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    //Ќе смог сделать через массив или список, забыл как(((

    [SerializeField]private Enemy[] enemyPrefabs;
    private float spawnAnyEnemyPositionY = 1;
    private float spawnEnemy1PositionX = 9.82f;
    private float spawnEnemy1PositionZ = -16.1f;
    private float spawnEnemy2PositionX = -7;
    private float spawnEnemy2PositionZ = -12;
    private float spawnEnemy3PositionX = 5.16f;
    private float spawnEnemy3PositionZ =-9;
    private float spawnEnemy4PositionX = -4.3f;
    private float spawnEnemy4PositionZ = -13.17f;
    private float spawnEnemy5PositionX = -13.5f;
    private float spawnEnemy5PositionZ = -12.8f;
    private float spawnEnemy6PositionX = 16.87f;
    private float spawnEnemy6PositionZ = 2.85f;
    private float spawnEnemy7PositionX = 4.38f;
    private float spawnEnemy7PositionZ = -7.86f;
    private float startDelay = 0.1f;
    private float spawnInterval = 1.0f;
    void Start()
    {   
        InvokeRepeating(nameof(SpawnRandomEnemy), startDelay, spawnInterval);
    }

    void SpawnRandomEnemy()
    {
        int enemyIndex = Random.Range(enemyPrefabs.Rank, enemyPrefabs.Length);
        Vector3 spawnPos = new (spawnEnemy1PositionX, spawnAnyEnemyPositionY, spawnEnemy1PositionZ);
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);

        enemyIndex = Random.Range(enemyPrefabs.Rank, enemyPrefabs.Length);
        spawnPos = new(spawnEnemy2PositionX, spawnAnyEnemyPositionY, spawnEnemy2PositionZ);
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);

        enemyIndex = Random.Range(enemyPrefabs.Rank, enemyPrefabs.Length);
        spawnPos = new(spawnEnemy3PositionX, spawnAnyEnemyPositionY, spawnEnemy3PositionZ);
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);

        enemyIndex = Random.Range(enemyPrefabs.Rank, enemyPrefabs.Length);
        spawnPos = new(spawnEnemy4PositionX, spawnAnyEnemyPositionY, spawnEnemy4PositionZ);
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);

        enemyIndex = Random.Range(enemyPrefabs.Rank, enemyPrefabs.Length);
        spawnPos = new(spawnEnemy5PositionX, spawnAnyEnemyPositionY, spawnEnemy5PositionZ);
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);

        enemyIndex = Random.Range(enemyPrefabs.Rank, enemyPrefabs.Length);
        spawnPos = new(spawnEnemy6PositionX, spawnAnyEnemyPositionY, spawnEnemy6PositionZ);
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);

        enemyIndex = Random.Range(enemyPrefabs.Rank, enemyPrefabs.Length);
        spawnPos = new(spawnEnemy7PositionX, spawnAnyEnemyPositionY, spawnEnemy7PositionZ);
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
    }
}
