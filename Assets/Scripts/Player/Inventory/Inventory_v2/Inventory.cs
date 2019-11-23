using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool ispicked1 = false;
    public bool ispicked2 = false;
    public GameObject pickable1;
    public GameObject pickable2;
   // public Rigidbody2D pickable1rb;
    public GameObject Parent;
    //public float force;
	public bool isThrown = false;
	public ThrowableObject throwableinstance1;
    public ThrowableObject throwableinstance2;
    public bool isfull = false; ///isto é para checkar se podes ou não pegar em mais objectos

    void Start() {
       // pickable1rb = GetComponent<Rigidbody2D>();
		throwableinstance1 = GameObject.Find("pickable1").GetComponent<ThrowableObject>();
        throwableinstance2 = GameObject.Find("pickable2").GetComponent<ThrowableObject>();
    }

     void Update() {
        if (ispicked1 == true) {
            pickable1.transform.position = Parent.transform.position;
			isfull = true;
        } 
      else if (ispicked1 == false) {
            pickable1.transform.parent = null;
        }

        if (ispicked2 == true) {
            pickable2.transform.position = Parent.transform.position;
            isfull = true;
        } else if (ispicked2 == false) {
            pickable2.transform.parent = null;
        }

        if (Input.GetMouseButton(1) && ispicked1 == true) {
            ispicked1 = false;
			isThrown = true;
			throwableinstance1.Throw();
			isfull = false;
           // pickable1rb.AddForce(transform.up * force, ForceMode2D.Impulse);
            // pickable1rb.AddForce(new Vector2(0, 2), ForceMode2D.Impulse);
        }

        if (Input.GetMouseButton(1) && ispicked2 == true) {
            ispicked2 = false;
            isThrown = true;
            throwableinstance2.Throw();
            isfull = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) {

        if (collision.gameObject.name == "pickable1" && isfull == false) {
            Debug.Log("Tocou em objecto");
            ispicked1 = true;
            pickable1.transform.SetParent(Parent.transform);
        }

        if (collision.gameObject.name == "pickable2" && isfull == false) {
            Debug.Log("Tocou em objecto");
            ispicked2 = true;
            pickable2.transform.SetParent(Parent.transform);
        }
    }

}
