using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 10f;
    [SerializeField] private float damage = 10f;

    private void Start()
    {
        Destroy(gameObject, 5f);
    }

    private void Update()
    {
        transform.position += bulletSpeed * Time.deltaTime * transform.forward;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Shoot(collision.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Shoot(other.gameObject);    
    }

    private void Shoot(GameObject collisionGO)
    {
        if(collisionGO.TryGetComponent(out HealthManager health))
        {
            health.Hit(damage);
        }
        Destroy(gameObject);
    }
}
