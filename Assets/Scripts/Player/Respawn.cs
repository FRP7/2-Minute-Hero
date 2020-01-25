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
        if(!collision.isTrigger) {
            teleportinstance.CanClick = true;
        }
        if (collision.gameObject.tag == "spawn") {
            teleportinstance.GetComponent<TeleportPlayer>().currentspawn = collision.transform;
        }
        if(collision.gameObject.name == "Tutorial") {
            teleportinstance.GetComponent<TeleportPlayer>().levelstate = 0;
        }
        if (collision.gameObject.name == "1st floor") {
            teleportinstance.GetComponent<TeleportPlayer>().levelstate = 1;
        }
        if (collision.gameObject.name == "2nd floor") {
            teleportinstance.GetComponent<TeleportPlayer>().levelstate = 2;
        }
        if (collision.gameObject.name == "3rd floor") {
            teleportinstance.GetComponent<TeleportPlayer>().levelstate = 3;
        }
        if (collision.gameObject.name == "4th floor") {
            teleportinstance.GetComponent<TeleportPlayer>().levelstate = 4;
        }
        if (collision.gameObject.name == "5th floor") {
            teleportinstance.GetComponent<TeleportPlayer>().levelstate = 5;
        }
        if (collision.gameObject.name == "6th floor") {
            teleportinstance.GetComponent<TeleportPlayer>().levelstate = 6;
        }
        if (collision.gameObject.name == "7th floor") {
            teleportinstance.GetComponent<TeleportPlayer>().levelstate = 7;
        }
        if (collision.gameObject.name == "8th floor") {
            teleportinstance.GetComponent<TeleportPlayer>().levelstate = 8;
        }
        if (collision.gameObject.name == "9th floor") {
            teleportinstance.GetComponent<TeleportPlayer>().levelstate = 9;
        }
    }
    }
