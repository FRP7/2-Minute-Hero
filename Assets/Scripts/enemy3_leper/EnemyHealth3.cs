using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth3 : MonoBehaviour
{
    public int EnemyHealthbar3;
    public GameObject Enemy3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(EnemyHealthbar3 == 0)
        {
            Debug.Log("Enemy dies");
            Destroy(Enemy3);
        }
    }
}
