using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int state;
    public GameObject hands;
    public Transform Player;
    public bool isPicked = false;

    //pickable variables
    public GameObject pickable;
    public Rigidbody2D pickablerb;
    //


    private void Awake() {
        state = 0;
    }

    private void FixedUpdate() {
        switch (state) {
            case 1:
                Debug.Log("Inventory cheio");
                pickable.transform.SetParent(hands.transform);
                pickable.transform.position = hands.transform.position;
                pickablerb.isKinematic = true;
                pickablerb.simulated = false;
                isPicked = true;
                break;
            default:
                Debug.Log("Inventory vazio");
                isPicked = false;
                break;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //state = 0;
            pickable.transform.parent = null;
            pickablerb.isKinematic = false;
            pickablerb.simulated = true;
            Throw();
            pickable = null;
            pickablerb = null;
            state = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "pickable" && state == 0) {
            state = 1;
            pickable = collision.gameObject;
            SearchRigidBody();
            Debug.Log("Pegou");
        }
    }

    public void SearchRigidBody() {
        pickablerb = pickable.GetComponent<Rigidbody2D>();
    }

    public void Throw() {
         if(Player.localScale.x < 0) 
         {
             pickablerb.AddForce(transform.right * -1);
         } else if(Player.localScale.x > 0)
         {
             pickablerb.AddForce(transform.right);
         }
    }

}
