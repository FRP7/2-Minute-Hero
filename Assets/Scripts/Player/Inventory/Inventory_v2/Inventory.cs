using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int state;
    public GameObject hands;

    //pickable variables
    public GameObject pickable;
    public Rigidbody2D pickablerb;
    public ThrowableObject throwable;
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
                break;
            default:
                Debug.Log("Inventory vazio");
                /*pickable.transform.parent = null;
                pickablerb.isKinematic = false;
                pickablerb.simulated = true;
                pickable = null;
                pickablerb = null;*/
                break;
        }

        if (Input.GetMouseButton(1))
        {
            //state = 0;
            pickable.transform.parent = null;
            pickablerb.isKinematic = false;
            pickablerb.simulated = true;
            throwable.Throw();
            pickable = null;
            pickablerb = null;
            throwable = null;
            state = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "pickable" && state == 0) {
            state = 1;
            pickable = collision.gameObject;
            SearchRigidBody();
            SearchScript();
            Debug.Log("Pegou");
        }
    }

    public void SearchRigidBody() {
        pickablerb = pickable.GetComponent<Rigidbody2D>();
    }

    public void SearchScript() {
        throwable = pickable.GetComponent<ThrowableObject>();
    }

}
