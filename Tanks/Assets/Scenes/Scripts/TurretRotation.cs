using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretRotation : MonoBehaviour
{
    public int playerNumber = 1;
    public float rotateSpeed = 60f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float hInput = Input.GetAxis("P" + playerNumber.ToString() + "RightHorizontal");
        Vector3 turretRotation = new Vector3(0f, hInput * rotateSpeed * Time.deltaTime, 0f);
        Debug.Log(turretRotation);
        rb.MoveRotation(rb.rotation * Quaternion.Euler(turretRotation));
    }
}
