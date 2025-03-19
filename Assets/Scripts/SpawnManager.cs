using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] carPrefabs;
   private float spawnLimitXLeft = -9;
   private float spawnLimitXRIght = 9;
   private float spawnPosZ = 181;
   private float startDelay = 0.5f;
   private float spawnInterval = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomVehical", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomVehical()
    {
        int carIndex = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft,spawnLimitXRIght), 0, spawnPosZ);
        Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);
    }
}
