using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffMarks : MonoBehaviour
{
    private void Awake() {
        DestroyEnemies();
    }
    public void DestroyEnemies() {
        /*foreach (GameObject go in GameObject.FindGameObjectsWithTag("mark")) {
            go.SetActive(false);
        }
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("Wall")) {
            go.SetActive(false);
        }
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("Wall1")) {
            go.SetActive(false);
        }*/
        /*foreach (GameObject go in GameObject.FindGameObjectsWithTag("mark")) {
            foreach (SpriteRenderer renderer in go.GetComponentsInChildren(typeof(Renderer))) {
                renderer.enabled = false;
            }
        }

        foreach (GameObject go in GameObject.FindGameObjectsWithTag("Wall")) {
            foreach (SpriteRenderer renderer in go.GetComponentsInChildren(typeof(Renderer))) {
                renderer.enabled = false;
            }
        }

        foreach (GameObject go in GameObject.FindGameObjectsWithTag("Wall1")) {
            foreach (SpriteRenderer renderer in go.GetComponentsInChildren(typeof(Renderer))) {
                renderer.enabled = false;
            }
        }*/

        foreach (GameObject go in GameObject.FindGameObjectsWithTag("mark")) {
            go.SetActive(false);
        }
    }
}
