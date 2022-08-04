using UnityEngine;

public class ShootingEnemy : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float spawnStep = 1f;
    [SerializeField] private float rotationSpeed = 1f;
    private float nextSpawnTime;
    //поиск по сцене
    private Transform player;

    private void Start()
    {
        player = FindObjectOfType<PlayerMovement>().transform;    
    } 
    private void Update()
    {
        LookAtPlayer();
        Shoot();
    }
    private void LookAtPlayer()
    {
        var direction = player.transform.position - transform.position;
        var rotation = Vector3.RotateTowards(transform.forward, direction, rotationSpeed * Time.deltaTime, 0f );
        transform.rotation = Quaternion.LookRotation( rotation );
    }
    private void Shoot()
    {
        if (nextSpawnTime < Time.time)
        {
            Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
            nextSpawnTime = Time.time + spawnStep;
        }
    }

}