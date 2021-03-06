﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2_bullet : MonoBehaviour
{
    public float speed = 3f;
    PlayerFight reflec;

    Rigidbody2D rb;

    private Transform player;
    public Transform drone;
    public Transform trigger;

    private Vector2 target;
    private Vector2 target1;

    Vector2 moveDirection;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        player = GameObject.FindGameObjectWithTag("Player").transform;

        target = new Vector2(player.position.x, player.position.y);

        target1 = new Vector2(drone.position.x, drone.position.y);
    }

    private void Update() {
        trigger = GameObject.FindGameObjectWithTag("enemy2_trigger").transform;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Hit");

            collision.GetComponent<Health>().HP -= 1;

            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "enemy" && reflec.isReflected == true)
        {
            Debug.Log("Hit");
            collision.GetComponent<Health>().HP -= 1;

            Destroy(this.gameObject);
        }
    }
}
