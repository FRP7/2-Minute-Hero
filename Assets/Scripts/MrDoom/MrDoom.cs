using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MrDoom : MonoBehaviour
{
    public Health heathinstance;
    public Slider healthbar;
    public Animator bossanimator;
    private void Awake()
    {
        
    }
    void Start()
    {

    }

    void Update()
    {
        healthbar.value = heathinstance.HP;
    }

    private void FixedUpdate()
    {
        //esta state machine chama os estados do animator de acordo 
        //com a vida do Mr Doom
        switch(heathinstance.HP)
        {
            case 0:
                Debug.Log("Dead");
                break;
            case 1:
                bossanimator.SetTrigger("Leper");
                Debug.Log("Leper");
                break;
            case 2:
                bossanimator.SetTrigger("Drone");
                Debug.Log("Drone");
                break;
        }
    }
}
