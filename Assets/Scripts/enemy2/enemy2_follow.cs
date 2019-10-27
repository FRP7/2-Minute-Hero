using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour
{
    //flip
    Vector3 enemy2Scale;
    float enemy2ScaleX;
    public float direction;
    //
    // Start is called before the first frame update
    void Start()
    {
        //flip
        enemy2Scale = transform.localScale;
        enemy2ScaleX = enemy2Scale.x;
        direction = transform.position.x;
        //
    }

    // Update is called once per frame
    void Update()
    {
        //flip
        if (direction > transform.position.x) {
            Debug.Log("Esta a mover para a esquerda");
            enemy2Scale.x = enemy2ScaleX;
        } else if (direction < transform.position.x) {
            Debug.Log("Esta a mover para a direita");
            enemy2Scale.x = -enemy2ScaleX;
        }
        direction = transform.position.x;
        //
    }
}
