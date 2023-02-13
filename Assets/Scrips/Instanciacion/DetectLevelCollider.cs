using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectLevelCollider : MonoBehaviour
{
    [SerializeField] SpamwTiles callToLevelGenerator;

    private void Start()
    {
        callToLevelGenerator=FindObjectOfType<SpamwTiles>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("funciona");
        callToLevelGenerator.ChooseLevel();
        callToLevelGenerator.DestroyLevel();
    }
}
