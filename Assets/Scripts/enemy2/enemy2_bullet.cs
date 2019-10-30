using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2_bullet : MonoBehaviour
{
    float moveSpeed = 7f;

    Rigidbody2D rb;

    public GameObject target;
    Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.Find("enemy2_trigger");
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
      //  Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.name == "Player") {
            Debug.Log("Acertou!");
            //Destroy(gameObject);
        }
    }

}
