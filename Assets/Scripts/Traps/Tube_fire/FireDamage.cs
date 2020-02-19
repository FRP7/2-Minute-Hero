using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDamage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "enemy") {
            collision.gameObject.GetComponent<Health>().HP -= 1;
            Debug.Log("burn");
        }

        if (collision.gameObject.tag == "Player") {
            collision.gameObject.GetComponent<Health>().HP -= 1;
            Debug.Log("burn");
        }
    }
}
