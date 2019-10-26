using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int EnemyHealthbar = 10;
    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(EnemyHealthbar == 0)
        {
            Debug.Log("Enemy dies");
            Destroy(Enemy);
        }
    }
}
