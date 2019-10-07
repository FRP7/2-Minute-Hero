using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public GameObject Player;
    public int speed;
    public int direction;

    public float horizontalMove = 0f;
    public float verticalMove = 20f;

    public bool jump;

    // Start is called before the first frame update
    void Awake()
    {
        speed = 5;
        direction = 1;
        jump = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("Beep");
            direction = -1;
        }

        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Boop");
            direction = 1;
        }


        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Jumpy jump");
            jump = true;
        }
    }

    void Movement()
    {
        //Auto movement
        horizontalMove = speed * direction;
        transform.Translate(Vector2.right * horizontalMove * Time.deltaTime);

        //Jump
        if(jump == true)
        {
            transform.Translate(Vector2.up * verticalMove * Time.deltaTime);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
            direction = 1;
        if (collision.gameObject.tag == "Wall1")
            direction = -1;
    }
}
