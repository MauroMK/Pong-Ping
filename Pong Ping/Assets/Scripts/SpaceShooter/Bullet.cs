using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;

    private float deadZoneY = 6f;

    void Update()
    {
        transform.Translate(Vector2.up * bulletSpeed * Time.deltaTime);

        if (transform.position.y >= deadZoneY)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("EnemyShip"))
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
