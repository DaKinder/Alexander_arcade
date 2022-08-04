using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class FollowingEnemy : Enemy
{
    private NavMeshAgent agent;
    private Transform player;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = FindObjectOfType<PlayerMovement>().transform;
    }

    private void Update()
    {
        agent.SetDestination(player.position);
    }
}
