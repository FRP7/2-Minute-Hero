using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2_trigger : MonoBehaviour
{
    public bool canShoot = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("drone gon shoot");
            canShoot = true;
        }
    }
}
