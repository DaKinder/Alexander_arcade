using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private float runspeed = 10f;

    private Vector3 direction;
    private bool isRunning;
    private bool isJump;

    void Update()
    {
        direction.x = Input.GetAxis("SideStep");
        direction.z = Input.GetAxis("ForwardBackward");
        direction.y = Input.GetAxis("Jump");
        isRunning = Input.GetButton("Running");

        transform.position += direction * (isRunning ? runspeed : speed) * Time.deltaTime;
    }
}
