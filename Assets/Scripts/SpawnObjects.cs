using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    //Spawn point
    public GameObject SpawnPoint;
    //prefab
    public GameObject SpawnPrefab;

    public bool once = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && once == false)
        {
            Instantiate(SpawnPrefab, SpawnPoint.transform.position, SpawnPoint.transform.rotation);
            once = true;
        }
    }
}