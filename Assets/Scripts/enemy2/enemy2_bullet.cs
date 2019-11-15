using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2_bullet : MonoBehaviour
{
    public float moveSpeed = 3f;

    Rigidbody2D rb;

    public GameObject target;
    Vector2 moveDirection;

    public PlayerHealth playerinstance;

    // Start is called before the first frame update
    void Start()
    {
        playerinstance = GameObject.FindWithTag("Player").GetComponent<PlayerHealth>();
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.Find("enemy2_trigger");
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        //se quiseres meter animação de bala a se destruir deves meter aqui
        Destroy(gameObject, 1f);
     //   Debug.Log("Destroy");
    }

    // Update is called once per frame
    void Update()
    {
        //se meteres alguma animação na bala (por exemplo, fogo a volta idk) deves meter aqui
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.name == "Player") {
            Debug.Log("Acertou!");
            playerinstance.GetComponent<PlayerHealth>().Healthbar-=1;
            //se quiseres meter animação da bala a destruir ao acertar no jogador deves mete aqui
            Destroy(gameObject);
        }
    }

}
