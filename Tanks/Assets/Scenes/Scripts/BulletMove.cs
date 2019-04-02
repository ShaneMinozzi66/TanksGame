using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float fireRate = 1f;
    public float bulletSpeed = 10f;
    public float bulletLife = 2f;

     private void Update()
    {
        MoveBullet();
    }

    private void MoveBullet()
    {
        if (bulletSpeed > 0)
        {
            transform.position += transform.forward * bulletSpeed * Time.deltaTime;
        }
    }
}

