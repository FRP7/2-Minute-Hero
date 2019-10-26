using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool ispicked1 = false;
    public GameObject pickable1;
    public Rigidbody2D pickable1rb;
    public GameObject Parent;
    public float force;

    void Start() {
        pickable1rb = GetComponent<Rigidbody2D>();
    }

     void Update() {
        if (ispicked1 == true) {
            pickable1.transform.position = Parent.transform.position;
        } 
      else if (ispicked1 == false) {
            pickable1.transform.parent = null;
        }

        if (Input.GetMouseButton(1) && ispicked1 == true) {
            ispicked1 = false;
            pickable1rb.AddForce(transform.up * force, ForceMode2D.Impulse);
            // pickable1rb.AddForce(new Vector2(0, 2), ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) {

        if (collision.gameObject.name == "pickable1") {
            Debug.Log("Tocou em objecto");
            ispicked1 = true;
            pickable1.transform.SetParent(Parent.transform);
        }
    }

}
