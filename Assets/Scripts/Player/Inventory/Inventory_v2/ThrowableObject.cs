using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowableObject : MonoBehaviour
{
    public Inventory inv;

    public float speed;


    bool hit = false;

    public void Throw()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            col.gameObject.GetComponent<EnemyHealth1>().EnemyHealthbar -= 1;
            Destroy(this.gameObject);
        }
    }
}
