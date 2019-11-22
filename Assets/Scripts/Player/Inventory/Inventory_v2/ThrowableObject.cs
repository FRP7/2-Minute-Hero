using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowableObject : MonoBehaviour
{

	public Inventory inventoryinstance;
	public Rigidbody2D throwablerb;
	public Transform Player;
	
    // Start is called before the first frame update
    void Start()
    {
        inventoryinstance = GameObject.Find("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
		/*if(Player.localScale.x < 1)
		{
			Debug.Log("Esquerda");
		} else if(Player.localScale.x > 0)
		{
			Debug.Log("Direita");
		}*/
    }
	
	public void Throw()
	{
		/*if(inventoryinstance.isThrown = true)
		{
			Debug.Log("Atirou");
		}*/
		Debug.Log("Atirou");
		//throwablerb.AddForce(transform.right);
		//throwablerb.AddForce(transform.right * -1);
		if(Player.localScale.x < 1)
		{
			throwablerb.AddForce(transform.right * -1);
		} else if(Player.localScale.x > 0)
		{
			throwablerb.AddForce(transform.right);
		}
	}
}
