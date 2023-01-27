using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Transform barrel;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float startTimeBtwShots;
    private float timeBtwShots;

    void Start()
    {
        timeBtwShots = startTimeBtwShots;
    }

    void FixedUpdate()
    {
        if (timeBtwShots <= 0)
        {
            Shoot(bulletPrefab, barrel);
            timeBtwShots = startTimeBtwShots;
        }
        else
        {
            timeBtwShots -= Time.fixedDeltaTime;
        }
    }

    protected virtual void Shoot(GameObject bulletPrefab, Transform barrel)
    {
        Instantiate(bulletPrefab, barrel.position, barrel.rotation);
    }
}
