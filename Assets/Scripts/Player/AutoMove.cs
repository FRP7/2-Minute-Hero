﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public GameObject Player;
    public int speed;
    public int direction;

    Rigidbody2D rb;

    public float horizontalMove = 0f;
    public float jumpForce = 20f;
    [SerializeField]
    private float jumpTimer;
    [SerializeField]
    private float jumpTime;

    public bool isGrounded;
    public bool isJumping;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask isGround;

    //flip
    Vector3 characterScale;
    float characterScaleX;
    //

    void Start() {
        characterScale = transform.localScale;
        characterScaleX = characterScale.x;
    }

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 5;
        direction = 1;

    }

    // Update is called once per frame USE FOR MOVEMENT AND SHIT THAT DONT WANNA BE DEPENDANT OF FRAMES PER SECOND
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
            characterScale.x = -characterScaleX; //flip
        }

        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Boop");
            direction = 1;
            characterScale.x = characterScaleX; //flip
        }
        transform.localScale = characterScale; //flip

        //Jump
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Jumpy jump");
            isJumping = true;
            jumpTimer = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
        }

        //Held Jump
        if (isGrounded == true && Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow) && isJumping == true)
        {
            if(jumpTimer > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimer -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
            
        }

        if(Input.GetKeyUp(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow))
        {
            isJumping = false;
        }

        //check if player is grounded
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, isGround);
    }

    void Movement()
    {
        //Auto movement
        horizontalMove = speed * direction;
        transform.Translate(Vector2.right * horizontalMove * Time.deltaTime);
    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
            direction = 1;
        if (collision.gameObject.tag == "Wall1")
            direction = -1;
    }
}
