using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyMovement : MonoBehaviour
{
    private float speed;
    [SerializeField] private GameObject enemy;
    [SerializeField] private Dificulty dificulty;
    private Rigidbody2D enemyRb;
    private Vector3 startPosition;


    private enum Dificulty
    {
        Easy,
        Medium,
        Hard
    }

    void Awake()
    {
        enemyRb = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
    }

    void Start()
    {
        dificulty = Dificulty.Easy;
        speed = 5f;
        LeanTween.moveX(enemy, 2, speed).setEaseLinear().setLoopPingPong();
    }

    void Update()
    {
        switch (dificulty)
        {
            default:
            case Dificulty.Easy:
                speed = 10f;
                break;
            case Dificulty.Medium:
                speed = 2.5f;
                break;
            case Dificulty.Hard:
                speed = 0.5f;
                break;
        }
    }

    public void ResetPos()
    {
        transform.position = startPosition;
    }
}
