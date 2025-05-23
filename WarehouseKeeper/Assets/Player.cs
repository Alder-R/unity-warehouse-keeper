using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player iPlayer;
    [SerializeField] float speed = 10f;
    private Rigidbody playerRigidbody;
    Vector3 playerVelocity;
    void Start() 
    {
        iPlayer = this;
        playerRigidbody = GetComponent<Rigidbody>();
        Application.targetFrameRate = 30;
    }

    void Update()
    { 
        float inputX = Input.GetAxis("Horizontal"); 
        float inputZ = Input.GetAxis("Vertical");

        playerVelocity = new Vector3(inputX, 0, inputZ);

        playerVelocity = playerVelocity * speed;
    }

    private void FixedUpdate()
    {
        playerRigidbody.velocity = playerVelocity * Time.fixedDeltaTime;
    }
}
