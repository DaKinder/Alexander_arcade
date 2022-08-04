using UnityEngine;

public class ShootingPlayer : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform spawnPoint;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
        }

    }
}
