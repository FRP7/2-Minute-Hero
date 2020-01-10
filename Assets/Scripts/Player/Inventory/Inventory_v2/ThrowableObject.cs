using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowableObject : MonoBehaviour
{
    public Transform Player;
    public void Throw()
    {
        Debug.Log("Atirar");
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
