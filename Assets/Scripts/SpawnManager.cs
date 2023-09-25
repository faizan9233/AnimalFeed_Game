using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabAnimals;
    float Xrange = 20;
    float Zrange = 20;
    float DelayTIme = 2;
    float TImeRate = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", DelayTIme, TImeRate);
    }

    // Update is called once per frame
    void Update()
    {
       
        


    }

    void SpawnRandomAnimals()
    {

        int animalIndex = Random.Range(0, prefabAnimals.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-Xrange, Xrange), 0, Zrange);
        Instantiate(prefabAnimals[animalIndex], spawnpos, prefabAnimals[animalIndex].transform.rotation);


    }



}
