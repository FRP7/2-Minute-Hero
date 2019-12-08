using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowableObject : MonoBehaviour
{

    public Inventory inventoryinstance;
    public Rigidbody2D throwablerb;
    public Transform Player;
    public GameObject PickableObject;

    public EnemyHealth1 enemyhealth1instance;
    public EnemyHealth2 enemyhealth2instance;
    public EnemyHealth3 enemyhealth3instance;

    // Start is called before the first frame update
    void Start()
    {
        inventoryinstance = GameObject.Find("Player").GetComponent<Inventory>();

        enemyhealth1instance = GameObject.Find("Grunt").GetComponent<EnemyHealth1>();
        enemyhealth2instance = GameObject.Find("Drone").GetComponent<EnemyHealth2>();
        enemyhealth3instance = GameObject.Find("Leaper").GetComponent<EnemyHealth3>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Player.localScale.x < 1)
		{
			Debug.Log("Esquerda");
		} else if(Player.localScale.x > 0)
		{
			Debug.Log("Direita");
		}*/
    }

    public void Throw()
    {
        /*if(inventoryinstance.isThrown = true)
		{
			Debug.Log("Atirou");
		}*/
        Debug.Log("Atirou");
        //throwablerb.AddForce(transform.right);
        //throwablerb.AddForce(transform.right * -1);
        if (Player.localScale.x < 1)
        {
            throwablerb.AddForce(transform.right * -1);
        }
        else if (Player.localScale.x > 0)
        {
            throwablerb.AddForce(transform.right);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Grunt")
        {
            enemyhealth1instance.GetComponent<EnemyHealth1>().EnemyHealthbar1 -= 1;
            Destroy(PickableObject);
        }
        if (collision.gameObject.name == "Drone")
        {
            enemyhealth2instance.GetComponent<EnemyHealth2>().EnemyHealthbar2 -= 1;
            Destroy(PickableObject);
        }
        if (collision.gameObject.name == "Leaper")
        {
            enemyhealth3instance.GetComponent<EnemyHealth3>().EnemyHealthbar3 -= 1;
            Destroy(PickableObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "enemy1_hitbox")
        {
            enemyhealth1instance.GetComponent<EnemyHealth1>().EnemyHealthbar1 -= 1;
            Destroy(PickableObject);
        }
    }
}
