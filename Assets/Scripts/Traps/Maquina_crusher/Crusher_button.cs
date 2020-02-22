using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crusher_button : MonoBehaviour
{
    [SerializeField] private Crusher_STM crusherstminstance;
    [SerializeField] private GameObject button_off;
    [SerializeField] private GameObject button_on;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.Space))
        {
            crusherstminstance.GetComponent<Crusher_STM>();
            crusherstminstance.states = Crusher_STM.States.down;
            button_off.SetActive(false);
            button_on.SetActive(true);
        }
    }
}
