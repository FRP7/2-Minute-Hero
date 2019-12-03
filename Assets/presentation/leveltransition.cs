using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class leveltransition : MonoBehaviour
{
	public bool scene0;
	public bool scene1;
	public bool scene2;
	public bool scene3;
	public bool scene4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.tag == "Player" && scene0 == true)
		{
			SceneManager.LoadScene("Level1");
		}
			if(collision.gameObject.tag == "Player" && scene1 == true)
		{
			SceneManager.LoadScene("Level2");
		}
		if(collision.gameObject.tag == "Player" && scene2 == true)
		{
			SceneManager.LoadScene("Level3");
		}
		if(collision.gameObject.tag == "Player" && scene3 == true)
		{
			SceneManager.LoadScene("Level4");
		}
		if(collision.gameObject.tag == "Player" && scene4 == true)
		{
			SceneManager.LoadScene("Level5");
		}
	}
	
}
