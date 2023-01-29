using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpamwTiles : MonoBehaviour
{

    public GameObject tileToSpawn;  // referenciar el tile base
    public GameObject referenceObject;
    public float timeOffset = 0.4f;  // este es el tiempo entre instancias
    public float distanceBetweenTiles = 20.0F;
    public float randomValue = 0.8f;
    private Vector3 previousTilePosition;   // Determina el punto de partida, cambiar esto va a cambiar el transform luego va a ser importante para ver toda instancia ya creada
    private float startTime;  
    private Vector3 direction, mainDirection = new Vector3(0, 0, 1), otherDirection = new Vector3(1, 0, 0);

    void Start()
    {
        previousTilePosition = referenceObject.transform.position; // Unica llamada, es la salida
        startTime = Time.time;   
    }

    void Update()
    {
        if (Time.time - startTime > timeOffset)
        {
            if (Random.value < randomValue)
                direction = mainDirection;
            else
            {
                Vector3 temp = direction;
                direction = otherDirection;
                mainDirection = direction;
                otherDirection = temp;
            }
            Vector3 spawnPos = previousTilePosition + distanceBetweenTiles * direction;
            startTime = Time.time;
            Instantiate(tileToSpawn, spawnPos, Quaternion.Euler(90, 90, 0)); // esto tiene que adaptarse a la forma de salida del escenario, alterar rot
            previousTilePosition = spawnPos;
        }
    }
}