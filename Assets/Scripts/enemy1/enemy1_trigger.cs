using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1_trigger : MonoBehaviour
{
	Animator AnimController;
	public GameObject DamageZone;
	public GameObject enemy1_hitbox;
    // Start is called before the first frame update
    void Start()
    {
        AnimController = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	///liga e desliga arma, é aqui onde deve estar a animação do combate
	void OnCollisionStay2D(Collision2D collision)
	{
		if(collision.gameObject.tag == "Player")
		{
			//Debug.Log("Triga animation");
			//AnimController.Play("enemy1_example");
			DamageZone.SetActive(true); 
			enemy1_hitbox.SetActive(true);
            AnimController.SetBool("isAttacking", true);
        } 
	}

    void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.tag == "Player") {
            
            DamageZone.SetActive(false);
			enemy1_hitbox.SetActive(false);
            AnimController.SetBool("isAttacking", false);
            //  Debug.Log("Jogador saiu");
        }
    }
}
