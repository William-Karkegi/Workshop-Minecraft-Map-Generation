using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = -9.8f;
    public float jumpHeight = 3f;
    
    public Transform groundCheck;
    public float groundDistance = .4f;
    public LayerMask groundMask;

    private Vector3 velocity;
    private CharacterController controller;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded && velocity.y < 0)
            velocity.y = -2f;

        // TODO : get input, move player
    }
}
