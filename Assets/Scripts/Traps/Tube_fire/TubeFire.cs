using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeFire : MonoBehaviour
{
    public enum states
    {
        on,
        off,
        idle
    }
    public states statemachine;
    [SerializeField] private GameObject Fire;
    [SerializeField] private GameObject DamagedTube;
    [SerializeField] private float time;
    public bool isIdle;

    private void Start() {
        statemachine = states.idle;
    }

    private void FixedUpdate() {
        StateMachine();
    }

    public void StateMachine() {
        switch(statemachine) {
            case states.on:
                Fire.SetActive(true);
                DamagedTube.SetActive(true);
                StartCoroutine(ExecuteAfterTime(time));
                isIdle = false;
                break;
            case states.idle:
                Fire.SetActive(false);
                DamagedTube.SetActive(false);
                isIdle = true;
                break;
            case states.off:
                Fire.SetActive(false);
                DamagedTube.SetActive(true);
                isIdle = false;
                break;
            default:
                Fire.SetActive(false);
                DamagedTube.SetActive(false);
                break;
        }
    }

    IEnumerator ExecuteAfterTime(float time) {
        yield return new WaitForSeconds(time);

        statemachine = states.off;
    }

}
