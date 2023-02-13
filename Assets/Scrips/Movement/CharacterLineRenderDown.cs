using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLineRenderDown : MonoBehaviour
{
    [SerializeField] float detectLevelHeiht;  
    [SerializeField] private LayerMask _layerMask;
    private RaycastHit _hitCollider;
    [SerializeField] private float descendSpeed;
    [SerializeField] private GameObject ShipModel;


    void Update()
    {       
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out _hitCollider, detectLevelHeiht, _layerMask))
        {
            Debug.Log("Is not safe to descend");           
            Debug.DrawLine(transform.position, transform.position + (transform.rotation * Vector3.down) * detectLevelHeiht, Color.red);
        }
        else 
        {
            Debug.Log("keep descending");       
            ShipModel.transform.localPosition+=  new Vector3(0, -1, 0) * (descendSpeed * Time.deltaTime);
        }
    }
}


//codigo original
/*
        if (Physics.Raycast(transform.position, Vector3.down, out _hitCollider, detectLevelHeiht, _layerMask))
        {
            Debug.Log("Is not safe to descend");
            Debug.DrawLine(transform.position, transform.position + Vector3.down * 15f, Color.red);
        }
        else 
        {
            Debug.Log("keep descending");       
            ShipModel.transform.localPosition+=  new Vector3(0, -1, 0) * (descendSpeed * Time.deltaTime);*/
