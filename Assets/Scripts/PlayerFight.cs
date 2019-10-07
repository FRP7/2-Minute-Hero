using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFight : MonoBehaviour
{
    public EnemyHealth enemyhealthinstance;
    // Start is called before the first frame update
    void Start()
    {
        enemyhealthinstance = GameObject.FindWithTag("enemy").GetComponent<EnemyHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Enemy: " + enemyhealthinstance.GetComponent<EnemyHealth>().EnemyHealthbar);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "enemy")
            enemyhealthinstance.GetComponent<EnemyHealth>().EnemyHealthbar--;
    }

}
