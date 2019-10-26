using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1chase : MonoBehaviour
{
   public float speed;
   public float stoppingDistance;
   
   private Transform target;
   
   void Start()
   {
	target = GameObject.FindGameObjectWithTag("Player")
	.GetComponent<Transform>();
   }
   
   void FixedUpdate()
   {
	if(Vector2.Distance(transform.position, target.position) > stoppingDistance)
	{
		transform.position = Vector2.MoveTowards
		(transform.position, target.position, speed * Time.deltaTime);
		
		Vector2 pos = transform.position;
     pos.y = 0;
     transform.position = pos;

	}
   }
   
}
