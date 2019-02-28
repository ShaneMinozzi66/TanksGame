using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] GameObject tank;
    [SerializeField] GameObject pivot;
    [SerializeField] GameObject chase;


    void LateUpdate()
    {
        pivot.transform.position = tank.transform.position;
        pivot.transform.rotation = tank.transform.rotation;

        transform.position = chase.transform.position;

        transform.LookAt(tank.transform.position);
    }
}
