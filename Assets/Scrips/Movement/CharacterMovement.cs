using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float giroSpeed;

    void Update()   
    {
        float horizontal = Input.GetAxis("Horizontal");               
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.forward, horizontal * (giroSpeed * Time.deltaTime));       
    }
}
