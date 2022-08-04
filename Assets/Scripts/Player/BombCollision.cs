using UnityEngine;

public class BombCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        Destroy(gameObject);
        Destroy(collider.gameObject);
    }
}
