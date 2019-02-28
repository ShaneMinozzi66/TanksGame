using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class MoveTank : MonoBehaviour
{
    public float moveSpeed = 3f;
    public int playerNumber = 1;
    public float rotateSpeed = 60f;
    public Rigidbody turretRB;

    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        float hMovement = Input.GetAxis("P" + playerNumber.ToString() + "LeftHorizontal");
        float vMovement = Input.GetAxis("P" + playerNumber.ToString() + "LeftVertical");
       
        Vector3 movement = new Vector3 (0f, 0f, vMovement * moveSpeed * Time.deltaTime);
        rb.MovePosition(transform.position + transform.TransformDirection(movement));
        turretRB.MovePosition(turretRB.transform.position + transform.TransformDirection(movement));

        Vector3 rotation = new Vector3(0f, hMovement * rotateSpeed * Time.deltaTime, 0f);
        Debug.Log(rotation);
        Quaternion finalRotation = Quaternion.Euler(rotation);
        rb.MoveRotation(rb.rotation * finalRotation);
        turretRB.MoveRotation(turretRB.rotation * finalRotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
