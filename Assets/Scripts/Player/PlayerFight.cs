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
        enemyhealth1instance = GameObject.Find("enemy1").GetComponent<EnemyHealth1>();
        enemyhealth2instance = GameObject.Find("enemy2").GetComponent<EnemyHealth2>();
        enemyhealth3instance = GameObject.Find("enemy3_leper").GetComponent<EnemyHealth3>();
    }

    // Update is called once per frame
    void Update()
    {
      //  Debug.Log("Enemy: " + enemyhealth1instance.GetComponent<EnemyHealth1>().EnemyHealthbar1);
      //  Debug.Log("Enemy: " + enemyhealth2instance.GetComponent<EnemyHealth2>().EnemyHealthbar2);
      //  Debug.Log("Enemy: " + enemyhealth3instance.GetComponent<EnemyHealth3>().EnemyHealthbar3);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.name == "enemy1") {
                enemyhealth1instance.GetComponent<EnemyHealth1>().EnemyHealthbar1--;
    }
     if (collision.gameObject.name == "enemy2") {
            enemyhealth2instance.GetComponent<EnemyHealth2>().EnemyHealthbar2--;
    }
 if (collision.gameObject.name == "enemy3_leper") {
            enemyhealth3instance.GetComponent<EnemyHealth3>().EnemyHealthbar3--;
    }
    }

}
