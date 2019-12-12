using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crusher : MonoBehaviour
{
    Health health;

    [SerializeField] float speed;
    [SerializeField] Transform pos1, pos2;
    [SerializeField] Transform startPos;

    //[SerializeField] GameObject enemies;
    //[SerializeField] BoxCollider2D killZone;

    Vector3 nextPos;

    void Start()
    {
        nextPos = startPos.position;
    }

    
    void Update()
    {
        if(transform.position == pos1.position)
        {
            nextPos = pos2.position;
        }
        if(transform.position == pos2.position)
        {
            nextPos = pos1.position;    
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "enemy" || collision.tag == "Player")
        {
            collision.GetComponent<Health>().HP -= 20;
        }   
    }
}
