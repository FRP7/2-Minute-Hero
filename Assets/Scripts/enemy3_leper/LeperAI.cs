using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeperAI : MonoBehaviour
{
	public Animator AnimLeper;
	
	public LeperTrigger lepertriggerinstance;
	
    // Start is called before the first frame update
    void Start()
    {
		AnimLeper = GetComponent<Animator>();
	    lepertriggerinstance = null; 
    }

    // Update is called once per frame
    void Update()
    {
       if( lepertriggerinstance != null && lepertriggerinstance.IsOnLeper )
    {
        Debug.Log("Leper jump");
		AnimLeper.Play("leper_jump");
    } 
    }
}
