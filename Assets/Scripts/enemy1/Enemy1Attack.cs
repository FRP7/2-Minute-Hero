using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Attack : MonoBehaviour
{
   // Start is called before the first frame update
    public PlayerHealth playerinstance;
    void Start()
    {
        playerinstance = GameObject.FindWithTag("Player").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
      //  Debug.Log("Player: " + playerinstance.GetComponent<PlayerHealth>().Healthbar);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Player")
            playerinstance.GetComponent<PlayerHealth>().Healthbar--;
    }
}
