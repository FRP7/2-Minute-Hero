using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warping : MonoBehaviour
{
    [SerializeField] private GameObject warpEntrance;
    [SerializeField] private GameObject Player;

    GameObject cameraOffset;

    private void Update() {
        Player = GameObject.FindWithTag("Player");
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine( Warp());
        }
    }

    IEnumerator Warp()
    {
        yield return new WaitForSeconds(0.01f);
        
        Player.transform.position = new Vector2(warpEntrance.transform.position.x,
                warpEntrance.transform.position.y);

        Camera.main.transform.position = new Vector3(0, -11, -5);
    }
}
    