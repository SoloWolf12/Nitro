using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLineRender : MonoBehaviour
{
    [SerializeField] float detectLevelHeiht;  //distancia del rayo, hay uno para adelante o cruzar uno de forma diagonal como un parachoques?
    [SerializeField]private LayerMask _layerMask;
    private RaycastHit _hitCollider;
    [SerializeField] private float ascencionSpeed;
    [SerializeField] private GameObject ShipModel;


    void Update()
    {
       
     if (Physics.Raycast(transform.position, transform.forward, out _hitCollider, detectLevelHeiht, _layerMask))
        {
            Debug.DrawLine(transform.position, _hitCollider.point, Color.blue);
            Debug.Log("go up NOW!!");
            ShipModel.transform.position += transform.position.y * new Vector3(0, -1, 0) * (ascencionSpeed * Time.deltaTime);
        }
    }
}
