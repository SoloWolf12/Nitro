using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorrarMovimiento : MonoBehaviour
{
    [SerializeField] private float speed;
    void Start()
    {
        
    }

    void Update()
    {
        Move();
    }

    private void Move() 
    {
        transform.localPosition += new Vector3(1, 0, 0)*(speed*Time.deltaTime);
    }
}
