using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy3_follow : MonoBehaviour
{
    //flip
    Vector3 enemy3Scale;
    float enemy3ScaleX;
    public float direction;
    //
    // Start is called before the first frame update
    void Start()
    {
        //flip
        enemy3Scale = transform.localScale;
        enemy3ScaleX = enemy3Scale.x;
        direction = transform.position.x;
        //
    }

    // Update is called once per frame
    void Update()
    {
        //flip
        if (direction > transform.position.x) {
            Debug.Log("Esta a mover para a esquerda");
            enemy3Scale.x = enemy3ScaleX;
        } else if (direction < transform.position.x) {
            Debug.Log("Esta a mover para a direita");
            enemy3Scale.x = -enemy3ScaleX;
        }
        direction = transform.position.x;
        //
    }
}
