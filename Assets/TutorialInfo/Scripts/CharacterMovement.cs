using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float movementSpeed, coefficient;
    [SerializeField] private LayerMask WhatIsGround;
    [SerializeField] AnimationCurve animCurve;
    [SerializeField] private float Time;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
  
    private void Update()
    {
        Movement(GetRb(), new Vector3(GetRb().velocity.x, 0, GetRb().velocity.z)
);
        SurfaceAligment();
    }

    private Rigidbody GetRb()
    {
        return rb;
    }

    private void Movement(Rigidbody rb, Vector3 counterMovement)
    {
        var x = Input.GetAxisRaw("Horizontal");
        var y = Input.GetAxisRaw("Vertical");
        Vector3 movement = new Vector3(x, 0, y);
        rb.AddForce(movement * movementSpeed);
        rb.AddForce(counterMovement * coefficient);
    }

    private void SurfaceAligment()
    {
        Ray ray = new Ray(transform.position, transform.up);
        RaycastHit info = new RaycastHit();
        Quaternion RotationRef = Quaternion.Euler(0, 0, 0);

        if(Physics.Raycast(ray, out info, WhatIsGround))
        {
            RotationRef = Quaternion.Lerp(transform.rotation, Quaternion.FromToRotation(Vector3.up, info.normal), animCurve.Evaluate(Time));
            transform.rotation = Quaternion.Euler(RotationRef.eulerAngles.x, transform.eulerAngles.y, RotationRef.eulerAngles.z);
        }
    }
}