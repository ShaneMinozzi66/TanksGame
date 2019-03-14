using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] GameObject tank;
    [SerializeField] GameObject MG42;
    [SerializeField] GameObject pivot;
    [SerializeField] GameObject chase;
    [SerializeField] GameObject chaseADS;

    private bool followingChaseADS = false;

    void LateUpdate()
    {

        pivot.transform.position = tank.transform.position;
        pivot.transform.rotation = tank.transform.rotation;

        if (Input.GetButton("P1ADS"))
        {
            followingChaseADS = true;
        }
        else followingChaseADS = false;
        Debug.Log(followingChaseADS);
        transform.position = chase.transform.position;

        transform.LookAt(tank.transform.position);

        if (followingChaseADS == true)
        {
            transform.position = chaseADS.transform.position;
            transform.LookAt(MG42.transform.position);
        }
    }
}
