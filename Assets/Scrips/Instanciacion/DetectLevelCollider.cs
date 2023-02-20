using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectLevelCollider : MonoBehaviour
{
    [SerializeField] SpamwTiles callToLevelGenerator;
    [SerializeField] private KeyCode keyCodeChangeLevel;

    private void Start()
    {
        callToLevelGenerator=FindObjectOfType<SpamwTiles>();
    }

    public void Update()
    {
        if (Input.GetKeyDown(keyCodeChangeLevel))
        {

            SceneManager.LoadScene("Testcollisions");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("funciona");
        callToLevelGenerator.ChooseLevel();
        callToLevelGenerator.DestroyLevel();
        GameManager.Instance.MetersCounter(50);
    }
}
