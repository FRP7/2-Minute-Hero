using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1_trigger : MonoBehaviour
{
	//public Animator AnimController;
	public GameObject DamageZone;
    // Start is called before the first frame update
    void Start()
    {
        //AnimController = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    }
	///liga e desliga arma, é aqui onde deve estar a animação do combate
	void OnCollisionStay2D(Collision2D collision)
	{
		if(collision.gameObject.name == "Player")
		{
			//Debug.Log("Triga animation");
			//AnimController.Play("enemy1_example");
			DamageZone.SetActive(true); 
		} 
	}

    void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.name == "Player") {
            DamageZone.SetActive(false);
          //  Debug.Log("Jogador saiu");
        }
    }
}
