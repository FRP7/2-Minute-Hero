using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaperAI : MonoBehaviour
{

    //Leaper shit
    public GameObject Leaper;
    public Rigidbody2D rb;
    public LeaperTrigger leapertriggerinstance;
    public BoxCollider2D meleeCol;

    public float jumpForce;
    public bool addOnce = true;

    public Animator leaperAnim;

    //Target player and shit
    public float speed;
    private Transform target;
    

    // Start is called before the first frame update
    void Start()
    {
        leaperAnim = GetComponent<Animator>();

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
                leaperAnim.SetBool("isJumping", true);

                Debug.Log("Leaper jump");
            }
        }
    }
}
