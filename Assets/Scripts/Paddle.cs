using System;
using UnityEngine;

/**
 * Controller Class for a paddle
 */
public class Paddle : MonoBehaviour
{
    private float moveSpeed;

    private void Start()
    {
        moveSpeed = 0.1f;
    }

    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(moveSpeed*direction,0,0);
    }
}
