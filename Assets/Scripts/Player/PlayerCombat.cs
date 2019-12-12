using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    Animator myAnim;

    public GameObject instanceWeapon;
    public GameObject hitbox;
    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Start anim
        if (Input.GetMouseButtonDown(0) && myAnim.GetBool("isAttacking") == false)
        {
            myAnim.SetBool("isAttacking", true);
        }

        //Resets anim
        else
            myAnim.SetBool("isAttacking", false);
    }
}
