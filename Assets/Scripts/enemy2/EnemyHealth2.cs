using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth2 : MonoBehaviour
{
    public int EnemyHealthbar2;
    public GameObject Enemy2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(EnemyHealthbar2 == 0)
        {
            Debug.Log("Enemy dies");
            Destroy(Enemy2);
        }
    }
}
