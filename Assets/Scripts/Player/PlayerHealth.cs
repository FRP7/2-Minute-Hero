using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int Healthbar = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
   // Debug.Log(Healthbar);
   if(Healthbar == 0)
     {
            Debug.Log("You died");
            SceneManager.LoadScene("SampleScene");
     }

    }
}
