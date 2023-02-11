using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTiles : MonoBehaviour
{
    [SerializeField] GameObject referenceTile;  //llamar al prefab final, luego hacerlo RNG
    [SerializeField] GameObject StartPos;       //Punto de salida 
    [SerializeField] private float timer;       //Esto se tiene que borrar mas adelante

    void Start()
    {
        timer = Time.time; 
    }

    void Update()
    {

        
    }
}
