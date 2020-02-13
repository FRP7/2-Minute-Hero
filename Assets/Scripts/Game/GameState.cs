using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public Health healthinstance;
    public bool isDead = false;

    private void Update() {
        if (healthinstance == null) {
            isDead = true;
        }
        if (healthinstance != null) {
            isDead = false;
        }
    }

    private void LateUpdate() {
        healthinstance = GameObject.FindWithTag("Player").GetComponent<Health>();
    }
}
