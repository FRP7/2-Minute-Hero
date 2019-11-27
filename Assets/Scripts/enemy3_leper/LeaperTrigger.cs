using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaperTrigger : MonoBehaviour
{
    public GameObject trigger;
    //public Animator AnimLeper;
    public bool IsTrigger = false;
    public BoxCollider2D bx;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Start Jump");
            IsTrigger = true;
            bx.enabled = false;
        }
    }
}
