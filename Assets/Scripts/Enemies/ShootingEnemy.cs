using UnityEngine;

public class ShootingEnemy : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float spawnStep = 10f;

    void Update()
    {
        Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}