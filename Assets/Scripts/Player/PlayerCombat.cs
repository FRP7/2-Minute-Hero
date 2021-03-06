﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    Animator myAnim;

    public GameObject instanceWeapon;
    public GameObject hitbox;

    public Inventory inventoryinstance;

    [SerializeField] private GameState gamestateinstance;


    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        inventoryinstance = GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        gamestateinstance = GameObject.Find("GameManager").GetComponent<GameState>();
        //Start anim
        if (Input.GetKeyDown(KeyCode.Space) && myAnim.GetBool("isAttacking") == false
            && gamestateinstance.CantAttack == false)
        {
            myAnim.SetBool("isAttacking", true);
        }

        //Resets anim
        else
            myAnim.SetBool("isAttacking", false);
    }
}
