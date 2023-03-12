using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private float speed;
    private float timer;

    void Start()
    {
        
    }

    void Update()
    {
        Move();
        timer += Time.deltaTime;
        TimeToDeath();
    }

    private void Move() 
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    private void TimeToDeath() 
    {
    if (timer > 15) 
        {
            Destroy(gameObject);
        }
    
    }
}
