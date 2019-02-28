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
        float fireTrigger = Input.GetAxis("p" + playerNumber.ToString() + "Fire");


        Debug.Log(fireTrigger);
    }
    
}
