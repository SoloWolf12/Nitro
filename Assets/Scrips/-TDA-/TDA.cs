using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


enum enemyNum
{
    uno,
    dos,
    tres
}
public class TDA : MonoBehaviour
{

    public GameObject[] spidersPrefab;
    [SerializeField] private enemyNum choseASpider;
     
    private Dictionary<enemyNum, GameObject> spidersDict= new Dictionary<enemyNum, GameObject>();
    [SerializeField] private List<Transform> spawnPoint;
    [SerializeField] private int[] spawnPointNumer;

    public void addToDiccionary() 
    {
        spidersDict.Add(enemyNum.uno, spidersPrefab[0]);
        spidersDict.Add(enemyNum.dos, spidersPrefab[1]);
        spidersDict.Add(enemyNum.tres, spidersPrefab[2]);
    }

    private void Start()
    {
        addToDiccionary();
       
    }

    void Update()
    {
        SpawnSpider();
    }

    private void SpawnSpider()
    {
        if (Input.GetKeyDown(KeyCode.Z)) 
        {
            int placeToSpawn = spawnPointNumer[0];
            Instantiate(spidersDict[choseASpider], spawnPoint[placeToSpawn]);            
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            int placeToSpawn = spawnPointNumer[1];
            Instantiate(spidersDict[choseASpider], spawnPoint[placeToSpawn]);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            int placeToSpawn = spawnPointNumer[2];
            Instantiate(spidersDict[choseASpider], spawnPoint[placeToSpawn]);
        }

    }
}
