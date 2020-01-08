using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrDoomSTM : MonoBehaviour
{
    public Health healthinstance;

    private void Start() 
    {
        healthinstance = GetComponent<Health>();
    }

    private void FixedUpdate() {
        switch(healthinstance.HP)
        {
            case 1:
                Debug.Log("Fase 3: leaper");
                break;
            case 2:
                Debug.Log("Fase 2: drone");
                break;
            case 3:
                Debug.Log("Fase 1: grunt");
                break;
            case 0:
                Debug.Log("Morre");
                break;

        ////o plano colocar os scripts dos outros inimigos no doom e depois ligar/desligar 
        ///nesta state machine, got it?
        }
    }
}
