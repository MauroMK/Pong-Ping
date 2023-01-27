using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] protected float bulletSpeed;
    
    public Vector2 direction2D;
    protected float deadZoneY = 6f;

    protected virtual void Update()
    {
        transform.Translate(direction2D * bulletSpeed * Time.deltaTime);

        if (transform.position.y >= deadZoneY)
        {
            Destroy(this.gameObject);
        }
    }

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("EnemyShip"))
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
