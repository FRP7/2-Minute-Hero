using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth1 : MonoBehaviour
{
    public int EnemyHealthbar1;
    public GameObject Enemy1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(EnemyHealthbar1 == 0)
        {
            Debug.Log("Enemy dies");
            Destroy(Enemy1);
        }
    }
}
