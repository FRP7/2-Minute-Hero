﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeperTrigger : MonoBehaviour
{
	public GameObject Leper;
	public GameObject trigger;
	//public Animator AnimLeper;
	public bool IsOnLeper = false;
    // Start is called before the first frame update
    void Start()
    {
       // AnimLeper = GetComponent<Animator>();
	 //  GameObject.Find("enemy3_leper").GetComponent<LeperAI>().lepertriggerinstance = this;
    }

    // Update is called once per frame
    void Update()
    {
		
    }
	
	 private void OnCollisionEnter2D(Collision2D collision)
		 {
				if (collision.gameObject.tag == "Player")
				{
				Debug.Log("Do something else here");
				Leper.transform.position = trigger.transform.position;
				//AnimLeper.Play("leper_jump");
				//IsOnLeper = true;
				}
		}
}
