using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportPlayer : MonoBehaviour
{
    public GameObject player;

    public Transform spawn1;
    public Transform spawn2;
    public Transform spawn3;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            player.transform.position = spawn1.position;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            player.transform.position = spawn2.position;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            player.transform.position = spawn3.position;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("0");
        }
    }
}
