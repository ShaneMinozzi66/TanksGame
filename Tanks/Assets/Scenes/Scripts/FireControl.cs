using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireControl : MonoBehaviour
{
    public int playerNumber = 1;
    public GameObject bulletObjects;
    public GameObject firePoint;
    public Transform barrelRotation;

    private bool canFire = true;
    private float TimeToFire = 0;

    void Start()
    {

    }


    void Update()
    {
        FireBullets();
    }


    private void FireBullets()
    {
        bool fireTrigger = Input.GetButtonDown("P" + playerNumber.ToString() + "Fire");


        if (fireTrigger && canFire)  //add fire rate
        {
            ShootBullets();
        }

        CheckFireRate();

    }

    private void CheckFireRate()
    {
        if (canFire == false)
        {
            if (TimeToFire > bulletObjects.GetComponent<BulletMove>().fireRate)
            {
                canFire = true;
            }
            else
            {
                TimeToFire += Time.deltaTime;
            }
        }
    }

    private void ShootBullets()
    {
        Instantiate(bulletObjects, firePoint.transform.position, barrelRotation.rotation * Quaternion.Euler(-90f, 0f, 0f));
        canFire = false;
        TimeToFire = 0;
    }
}
