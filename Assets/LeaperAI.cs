using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaperAI : MonoBehaviour
{

    //Leaper shit
    public GameObject Leaper;
    public Rigidbody2D rb;
    public LeaperTrigger leapertriggerinstance;
    public float jumpForce;
    public bool addOnce = true;
    public BoxCollider2D meleeCol;

    //Target player and shit
    public float speed;
    private Transform target;
    

    // Start is called before the first frame update
    void Start()
    {
        meleeCol.enabled = false;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (leapertriggerinstance.IsTrigger == true)
        {

            //AnimLeper.Play("leper_jump");
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            if (addOnce)
            {
                rb.AddForce(transform.up * jumpForce);
                addOnce = false;
                meleeCol.enabled = true;
                Debug.Log("Leaper jump");
            }
        }
    }
}
