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
    public Transform spawn4;
    public Transform spawn5;
    public Transform spawn6;
    public Transform spawn7;
    public Transform spawn8;

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

        if (Input.GetKeyDown(KeyCode.Alpha4)) {
            player.transform.position = spawn4.position;
        }

        if (Input.GetKeyDown(KeyCode.Alpha5)) {
            player.transform.position = spawn5.position;
        }

        if (Input.GetKeyDown(KeyCode.Alpha6)) {
            player.transform.position = spawn6.position;
        }

        if (Input.GetKeyDown(KeyCode.Alpha7)) {
            player.transform.position = spawn7.position;
        }

        if (Input.GetKeyDown(KeyCode.Alpha8)) {
            player.transform.position = spawn8.position;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}
