using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    
    private Vector2 movement;
    private Rigidbody2D playerRb;
    
    void Awake()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        HandleInput();
    }

    void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + movement * speed * Time.fixedDeltaTime);
    }

    private void HandleInput()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
    }
}
