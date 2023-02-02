using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float startSpeed;
    [SerializeField] private float extraSpeed;
    [SerializeField] private float maxExtraSpeed;

    public bool player1Start = true;
    private int hitCounter = 0;

    private Rigidbody2D rb;
    private Vector2 startPosition;

    void Start()
    {
        startPosition = transform.position;
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(LaunchBall());
    }

    public IEnumerator LaunchBall()
    {
        ResetBall();
        hitCounter = 0;
        yield return new WaitForSeconds(1);

        if (player1Start == true)
        {
            MoveBall(new Vector2(0, -1));
        }
        else
        {
            MoveBall(new Vector2(0, 1));
        }
    }

    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;

        float ballSpeed = startSpeed + hitCounter * extraSpeed;

        rb.velocity = direction * ballSpeed;
    }

    public void IncreaseHitCounter()
    {
        if (hitCounter * extraSpeed < maxExtraSpeed)
        {
            hitCounter++;
        }
    }
    
    public void ResetBall()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }


}
