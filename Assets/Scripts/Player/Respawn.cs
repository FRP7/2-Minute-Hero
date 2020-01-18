using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public TeleportPlayer teleportinstance;

    private void Update() {
        teleportinstance = GameObject.Find("SpawnPoints").GetComponent<TeleportPlayer>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "spawn") {
            teleportinstance.GetComponent<TeleportPlayer>().currentspawn = collision.transform;
        }
    }
}
