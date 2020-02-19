using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeFireCol : MonoBehaviour
{
    [SerializeField] private TubeFire tubefireinstance;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "playerweapon" 
            && tubefireinstance.isIdle == true) {
            tubefireinstance.GetComponent<TubeFire>();
            tubefireinstance.statemachine = TubeFire.states.on;
        }
    }
}
