using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingPlayer : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform spawnPoint;
    //[SerializeField] private float spawnStep = 1f;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
