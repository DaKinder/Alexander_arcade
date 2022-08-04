using UnityEngine;

public class SpawnManager : Enemy
{

    //Ќе смог сделать через массив или список, забыл как(((

    [SerializeField]public GameObject[] enemyPrefabs;
    private float spawnAnyEnemyPositionY = 1;
    private float spawnEnemy1PositionX = -7.5f;
    private float spawnEnemy1PositionZ = 3.2f;
    private float spawnEnemy2PositionX = -13.6f;
    private float spawnEnemy2PositionZ = 6f;
    private float spawnEnemy3PositionX = -7.5f;
    private float spawnEnemy3PositionZ = -5.6f;
    private float spawnEnemy4PositionX = -4.5f;
    private float spawnEnemy4PositionZ = -8.8f;
    private float spawnEnemy5PositionX = 8.9f;
    private float spawnEnemy5PositionZ = -8.8f;
    private float spawnEnemy6PositionX = 9.3f;
    private float spawnEnemy6PositionZ = -3.7f;
    private float spawnEnemy7PositionX = 16.4f;
    private float spawnEnemy7PositionZ = .5f;
    private float startDelay = 0.1f;
    private float spawnInterval = 1000.0f;
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
