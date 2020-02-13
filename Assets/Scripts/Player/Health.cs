using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int HP;

    //Animator anim;

    private void FixedUpdate()
    {
        if (HP <= 0)
        {
            Debug.Log(gameObject.tag + "Ded");
            //anim.Play("death");
            Destroy(this.gameObject);
        }
    }
}
