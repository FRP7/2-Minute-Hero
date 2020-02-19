using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeFire : MonoBehaviour
{
    public enum states
    {
        on,
        off
    }
    public states statemachine;
    [SerializeField] private GameObject Fire;
    [SerializeField] private float time;

    private void Start() {
        statemachine = states.off;
    }

    private void FixedUpdate() {
        StateMachine();
    }

    public void StateMachine() {
        switch(statemachine) {
            case states.on:
                Fire.SetActive(true);
                StartCoroutine(ExecuteAfterTime(time));
                break;
            case states.off:
                Fire.SetActive(false);
                break;
            default:
                Fire.SetActive(false);
                break;
        }
    }

    IEnumerator ExecuteAfterTime(float time) {
        yield return new WaitForSeconds(time);

        statemachine = states.off;
    }

}
