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
    public Transform spawn9;
    public Transform spawn10;

    //respawn
    public Transform currentspawn;
    public GameObject PlayerPrefab;
    public GameObject CameraPrefab;
    public GameObject Camera;
    public GameState CanRespawn;
    //

    // Update is called once per frame
    void FixedUpdate() {
        player = GameObject.FindWithTag("Player");
        Camera = GameObject.FindWithTag("Camera");
        QuickSpawn();
        Respawn();
    }

    public void QuickSpawn() {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            player.transform.position = spawn1.position;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            player.transform.position = spawn2.position;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3)) {
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

        if (Input.GetKeyDown(KeyCode.Alpha9)) {
            player.transform.position = spawn9.position;
        }

        if (Input.GetKeyDown(KeyCode.Alpha0)) {
            player.transform.position = spawn10.position;
        }
    }

    public void Respawn() {
        if (Input.GetKeyDown(KeyCode.R) && CanRespawn.GetComponent<GameState>().isDead == true) {
            //SceneManager.LoadScene("MainScene");
            Instantiate(PlayerPrefab, currentspawn);
            Destroy(Camera);
            Instantiate(CameraPrefab, currentspawn);
            CanRespawn.GetComponent<GameState>().isDead = false;
        }
    }
}
