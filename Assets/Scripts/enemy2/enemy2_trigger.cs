using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2_trigger : MonoBehaviour
{

	public enemy2_shoot enemy2instance;
	
    // Start is called before the first frame update
    void Start()
    {
        enemy2instance = GameObject.Find("enemy2weapon").GetComponent<enemy2_shoot>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnCollisionEnter2D(Collision2D collision) {
	// void OnCollisionStay2D(Collision2D collision) {

        if (collision.gameObject.name == "Player") {
           //Debug.Log("Enemy 2 trigou");
		   enemy2instance.Fire();
        } 
    }

}
