using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShockButton : MonoBehaviour
{
    [SerializeField] private ShockSTM ShockSTMinstance;
    [SerializeField] private GameObject button_off;
    [SerializeField] private GameObject button_on;
    [SerializeField] private bool isClick = false;

    private void OnTriggerStay2D(Collider2D other) {
        if (other.gameObject.tag == "Player" &&
            Input.GetKeyDown(KeyCode.Space) && isClick == false) {
            ShockSTMinstance.GetComponent<ShockSTM>();
            ShockSTMinstance.states = ShockSTM.State.on;
            button_off.SetActive(false);
            button_on.SetActive(true);
            isClick = true;
        }
    }
}
