using UnityEngine;

class Explosion : MonoBehaviour
{
    [SerializeField] GameObject bomb;
    [SerializeField] private float _radius;
    [SerializeField] private float _power;
    [SerializeField] private float _upForce;
    
    private HealthManager hm;

    private void OnCollisionEnter(Collision collision)
    {
        if(hm == GetComponent<HealthManager>())
        {
            Invoke(nameof(Detonate), 2);
        }
    }
    void Detonate()
    {
        Vector3 explosionPosition = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPosition, _radius);

        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddExplosionForce(_power, explosionPosition, _radius, _upForce, ForceMode.Impulse);
            }
        }
        Destroy(gameObject);
    }
}
