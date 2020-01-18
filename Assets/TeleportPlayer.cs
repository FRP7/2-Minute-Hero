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
    public GameObject[] pickablesillusion;
    //

    //respawn dos inimigos
    public int levelstate;
    public SpawnObjects[] spawners;
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
            DestroyEnemies();
            RespawnEnemies();
        }
    }

    public void DestroyEnemies() {
        foreach(GameObject go in GameObject.FindGameObjectsWithTag("enemy")) {
            Destroy(go);
        }
    }

    public void RespawnEnemies() {
        switch(levelstate) {
            case 0:
                spawners[0].GetComponent<SpawnObjects>().once = false;
                break;
            case 1:
                spawners[1].GetComponent<SpawnObjects>().once = false;
                spawners[2].GetComponent<SpawnObjects>().once = false;
                spawners[15].GetComponent<SpawnObjects>().once = false;
                pickablesillusion[0].SetActive(true);
                break;
            case 2:
                spawners[3].GetComponent<SpawnObjects>().once = false;
                break;
            case 3:
                spawners[4].GetComponent<SpawnObjects>().once = false;
                break;
            case 4:
                spawners[5].GetComponent<SpawnObjects>().once = false;
                break;
            case 5:
                spawners[6].GetComponent<SpawnObjects>().once = false;
                break;
            case 6:
                spawners[7].GetComponent<SpawnObjects>().once = false;
                spawners[8].GetComponent<SpawnObjects>().once = false;
                spawners[9].GetComponent<SpawnObjects>().once = false;
                break;
            case 7:
                spawners[10].GetComponent<SpawnObjects>().once = false;
                spawners[11].GetComponent<SpawnObjects>().once = false;
                spawners[12].GetComponent<SpawnObjects>().once = false;
                break;
            case 8:
                spawners[8].GetComponent<SpawnObjects>().once = false;
                break;
            case 9:
                spawners[9].GetComponent<SpawnObjects>().once = false;
                break;
        }
    }
}
