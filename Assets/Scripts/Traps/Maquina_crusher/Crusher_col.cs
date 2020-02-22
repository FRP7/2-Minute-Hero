using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crusher_col : MonoBehaviour
{
    [SerializeField] private bool damage = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy" && damage == true)
        {
            collision.gameObject.GetComponent<Health>().HP -= 1;
            damage = false;
            Debug.Log("Crush");
        }

        if (collision.gameObject.tag == "Player" && damage == true)
        {
            collision.gameObject.GetComponent<Health>().HP -= 1;
            damage = false;
            Debug.Log("Crush");
        }
    }
}
