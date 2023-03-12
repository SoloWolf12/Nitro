using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ControlWeapons : MonoBehaviour
{
    [SerializeField] private KeyCode fireA;
    [SerializeField] private GameObject ammoA;
    [SerializeField] private Transform origin;

    void Update()
    {
        CheckInputs();
    }

    private void CheckInputs() 
    {
        if (Input.GetKeyDown(fireA)) 
        {
            Instantiate(ammoA,origin.position,origin.rotation);
        }
    }
}
