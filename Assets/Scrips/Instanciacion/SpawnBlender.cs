using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlender : MonoBehaviour
{
    [SerializeField] private GameObject prefabToSpawn1;
    [SerializeField] private GameObject prefabToSpawn2;
    [SerializeField] private GameObject prefabToSpawn3;
    [SerializeField] private GameObject prefabToSpawn4;
    [SerializeField] private GameObject startPoint;
    [SerializeField] private Vector3 prefabAngle;
    [SerializeField] public float timeForNewGenPrefab = 1f;         //cuando se tenga movimiento cambiar por un colider    
    [SerializeField] public float distanceBetweenPrefabs; //por defecto es 50
    private int selectPrefab;
    private Vector3 _previousPrefabPosition;
    private float _startTime;
    private Vector3 _direction = new Vector3(0, 0, 1);
    void Start()
    {
        _previousPrefabPosition = startPoint.transform.position;
        _startTime = Time.time;
    }
    void Update()
    {
        ChooseLevel();
        DestroyLevel();
    }
    private void ChooseLevel()
    {
        selectPrefab = Random.Range(1, 5);
        GenerateLevel(selectPrefab);
    }
    private void GenerateLevel(int levelSelect)
    {
        if (levelSelect == 1)
        {
            if (Time.time - _startTime > timeForNewGenPrefab)
            {
                Vector3 spawnPos = _previousPrefabPosition + distanceBetweenPrefabs * _direction;
                _startTime = Time.time;
                Instantiate(prefabToSpawn1, spawnPos, Quaternion.Euler(prefabAngle));
                _previousPrefabPosition = spawnPos;
            }
        }
        else if (levelSelect == 2)
        {
            if (Time.time - _startTime > timeForNewGenPrefab)
            {
                Vector3 spawnPos = _previousPrefabPosition + distanceBetweenPrefabs * _direction;
                _startTime = Time.time;
                Instantiate(prefabToSpawn2, spawnPos, Quaternion.Euler(prefabAngle));

                _previousPrefabPosition = spawnPos;
            }
        }
        else if (levelSelect == 3)
        {
            if (Time.time - _startTime > timeForNewGenPrefab)
            {
                Vector3 spawnPos = _previousPrefabPosition + distanceBetweenPrefabs * _direction;
                _startTime = Time.time;
                Instantiate(prefabToSpawn3, spawnPos, Quaternion.Euler(prefabAngle));

                _previousPrefabPosition = spawnPos;
            }
        }
        else
        {
            if (Time.time - _startTime > timeForNewGenPrefab)
            {
                Vector3 spawnPos = _previousPrefabPosition + distanceBetweenPrefabs * _direction;
                _startTime = Time.time;
                Instantiate(prefabToSpawn4, spawnPos, Quaternion.Euler(prefabAngle));

                _previousPrefabPosition = spawnPos;
            }
        }
    }
    private void DestroyLevel()
    {
        GameObject[] allPrefabs = GameObject.FindGameObjectsWithTag("Level");
        if (allPrefabs.Length > 3)
        {
            Destroy(allPrefabs[0]);
        }
    }
}
