using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject hazard;
    void SpawnValues()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-3,3),0,10);
        Quaternion spawnRotation = Quaternion.identity;
        Instantiate(hazard, spawnPosition, spawnRotation);
    }
    void Start()
    {
        SpawnValues();
    }

}
