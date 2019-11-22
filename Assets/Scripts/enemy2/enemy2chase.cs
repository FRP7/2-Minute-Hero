using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2chase : MonoBehaviour
{

    Animator myAnim;

    public float speed;
   public float stoppingDistance;

    //flip
    Vector3 enemy1Scale;
    float enemy1ScaleX;
    public float direction;
    //
   
   private Transform target;
   
   void Start()
   {
        myAnim = GetComponent<Animator>(); 
        
        target = GameObject.FindGameObjectWithTag("Player")
	.GetComponent<Transform>();
        //flip
        enemy1Scale = transform.localScale;
        enemy1ScaleX = enemy1Scale.x;
        direction = transform.position.x;
        //
   }
   
   void FixedUpdate()
   {
	if(Vector2.Distance(transform.position, target.position) > stoppingDistance)
	{
		transform.position = Vector2.MoveTowards
		(transform.position, target.position, speed * Time.deltaTime);
		
		Vector2 pos = transform.position;
     pos.y = 5f;
     transform.position = pos;

            //deve ser algures por aqui que deves meter a animação do robot a voar
            myAnim.SetBool("isMoving", true);

        }

        transform.localScale = enemy1Scale;

   }

    void Update() {
        //flip
        if (direction > transform.position.x) {
            Debug.Log("Esta a mover para a esquerda");
            enemy1Scale.x = enemy1ScaleX;
        } else if(direction < transform.position.x) {
            Debug.Log("Esta a mover para a direita");
            enemy1Scale.x = -enemy1ScaleX;
        }
        direction = transform.position.x;
        //
    }

}
