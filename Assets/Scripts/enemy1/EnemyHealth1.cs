using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth1 : MonoBehaviour
{
    public int EnemyHealthbar;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(EnemyHealthbar <= 0)
        {
            Debug.Log("Enemy dies");
            Destroy(this.gameObject);
        }
    }
}
