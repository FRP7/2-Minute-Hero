using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrDoomSTM : MonoBehaviour
{
    [SerializeField] private Health healthinstance;

    private void FixedUpdate() {
        healthinstance = GetComponent<Health>();
        STM();
    }

    void STM() {
       if(healthinstance.HP <= 2) {
        }
        if (healthinstance.HP > 2) {
        }
    }
}
