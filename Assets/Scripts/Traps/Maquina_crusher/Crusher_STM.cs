using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crusher_STM : MonoBehaviour
{
    [SerializeField] private Transform crusher;
    [SerializeField] private Transform top;
    [SerializeField] private Transform down;

    public enum States {
        top,
        down
    }

    public States states;

    private void FixedUpdate() {
        STM();
    }

    private void STM() {
        switch (states) {
            case States.top:
                crusher.transform.position = top.transform.position;
                break;
            case States.down:
                crusher.transform.position = down.transform.position;
                break;
            default:
                crusher.transform.position = down.transform.position;
                break;
        }
    }
}
