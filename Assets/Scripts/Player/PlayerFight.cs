using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFight : MonoBehaviour
{
    public EnemyHealth1 enemyhealth1instance;
    public EnemyHealth2 enemyhealth2instance;
    public EnemyHealth3 enemyhealth3instance;
    // Start is called before the first frame update
    void Start()
    {
        enemyhealth1instance = GameObject.Find("Grunt").GetComponent<EnemyHealth1>();
        enemyhealth2instance = GameObject.Find("Drone").GetComponent<EnemyHealth2>();
        enemyhealth3instance = GameObject.Find("Leaper").GetComponent<EnemyHealth3>();
    }

    // Update is called once per frame
    void Update()
    {
        //  Debug.Log("Enemy: " + enemyhealth1instance.GetComponent<EnemyHealth1>().EnemyHealthbar1);
        //  Debug.Log("Enemy: " + enemyhealth2instance.GetComponent<EnemyHealth2>().EnemyHealthbar2);
        //  Debug.Log("Enemy: " + enemyhealth3instance.GetComponent<EnemyHealth3>().EnemyHealthbar3);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Grunt")
            enemyhealth1instance.GetComponent<EnemyHealth1>().EnemyHealthbar1 -= 1;

        if (collision.gameObject.name == "Drone")
            enemyhealth2instance.GetComponent<EnemyHealth2>().EnemyHealthbar2 -= 1;

        if (collision.gameObject.name == "Leaper")
            enemyhealth3instance.GetComponent<EnemyHealth3>().EnemyHealthbar3 -= 1;
    }

    //private void OnTriggerEnter2D(Collider2D col)
    //{
    //    if (col.gameObject.name == "enemy1_hitbox")
    //        enemyhealth1instance.GetComponent<EnemyHealth1>().EnemyHealthbar1 -= 1;
    //}
}
