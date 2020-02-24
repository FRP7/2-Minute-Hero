using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShockSTM : MonoBehaviour
{
    public enum State
    {
        idle,
        on,
        off
    }

    public State states;

    [SerializeField] private GameObject buttonoff;
    [SerializeField] private GameObject buttonon;
    [SerializeField] private GameObject shock;
    [SerializeField] private float time;

    private void FixedUpdate() {
        STM();
    }

    void STM() {
        switch(states) {
            case State.on:
                buttonoff.SetActive(false);
                buttonon.SetActive(true);
                shock.SetActive(true);
                StartCoroutine(ExecuteAfterTime(time));
                break;

            case State.idle:
                buttonoff.SetActive(true);
                buttonon.SetActive(false);
                shock.SetActive(false);
                break;

            case State.off:
                buttonoff.SetActive(false);
                buttonon.SetActive(true);
                shock.SetActive(false);
                break;

            default:
                buttonoff.SetActive(true);
                buttonon.SetActive(false);
                shock.SetActive(false);
                break;
        }
    }

    IEnumerator ExecuteAfterTime(float time) {
        yield return new WaitForSeconds(time);

        states = State.off;
    }

}
