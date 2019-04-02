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
        bool fireTrigger = Input.GetButtonDown("P" + playerNumber.ToString() + "Fire");
        float MG42Trigger = Input.GetAxis("P" + playerNumber.ToString() + "FireMG42");
        Debug.Log(MG42Trigger);

        if (fireTrigger && canFire)  //add fire rate
        {
            ShootBullets();
        }


        CheckFireRate();

        FireBullets();
    }


    private void FireBullets()
    {
        GameObject myBullet = Instantiate(bulletObjects, firePoint.transform.position, barrelRotation.rotation * Quaternion.Euler(180f, 0f, 0f));
        canFire = false;
        TimeToFire = 0;
        Destroy(myBullet, myBullet.GetComponent<BulletMove>().bulletLife);
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
        
        GameObject myBullet = Instantiate(bulletObjects, firePoint.transform.position, barrelRotation.rotation * Quaternion.Euler(180f, 0f, 0f));
        canFire = false;
        TimeToFire = 0;
        Destroy(myBullet,myBullet.GetComponent<BulletMove>().bulletLife);
    }
}
