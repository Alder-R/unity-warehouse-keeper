using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    private Rigidbody playerRigidbody;
    Vector3 playerVelocity;
    void Start() 
    { 
        playerRigidbody = GetComponent<Rigidbody>();
        Application.targetFrameRate = 30;
    }

    void Update()
    { 
        float inputX = Input.GetAxis("Horizontal"); 
        float inputZ = Input.GetAxis("Vertical");

        float fallSpeed = playerRigidbody.velocity.y;

        playerVelocity = new Vector3(inputX, 0, inputZ);

        playerVelocity = playerVelocity * speed;

        playerVelocity.y = fallSpeed;
    }

    private void FixedUpdate()
    {
        playerRigidbody.velocity = playerVelocity * Time.fixedDeltaTime;
    }
}
