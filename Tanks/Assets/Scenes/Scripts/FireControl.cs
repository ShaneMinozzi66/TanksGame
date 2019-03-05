using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireControl : MonoBehaviour
{
    public int playerNumber = 1;
    public GameObject bulletObjects;
    public GameObject firePoint;
    public Transform barrelRotation;



    void Start()
    {

    }


    void Update()
    {
        FireBullets();
    }


    private void FireBullets()
    {
        bool fireTrigger = Input.GetButtonDown("p" + playerNumber.ToString() + "Fire");


        if (fireTrigger)  //add fire rate
        {
            Instantiate(bulletObjects, firePoint.transform.position, barrelRotation.rotation);
            Debug.Log(fireTrigger);
        }
    }
    
}
