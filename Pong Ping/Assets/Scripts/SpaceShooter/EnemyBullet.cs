using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : Bullet
{
    protected override void Update()
    {
        transform.Translate(direction2D * bulletSpeed * Time.deltaTime);

        if (transform.position.y <= -deadZoneY)
        {
            Destroy(this.gameObject);
        }
    }

    protected override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
