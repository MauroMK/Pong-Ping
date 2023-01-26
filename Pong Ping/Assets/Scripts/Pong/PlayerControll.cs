using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    
    private Vector2 movement;
    public Rigidbody2D playerRb;

    private Vector3 startPosition;

    public bool isPlayer1;

    void Start()
    {
        startPosition = transform.position;
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
        if (isPlayer1)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
        }
        else
        {
            movement.x = Input.GetAxisRaw("Horizontal2");
        }
    }

    public void ResetPos()
    {
        playerRb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
