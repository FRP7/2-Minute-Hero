using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowableObject : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            Debug.Log("Acertou");
            col.gameObject.GetComponent<Health>().HP -= 1;
            Destroy(this.gameObject);
        }
    }
}
