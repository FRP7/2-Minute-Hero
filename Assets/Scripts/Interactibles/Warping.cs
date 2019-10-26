using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warping : MonoBehaviour
{
    [SerializeField] GameObject warpEntrance;
    [SerializeField] GameObject Player;
    //[SerializeField] Camera theCam;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine( Warp() );
        }
    }

    IEnumerator Warp()
    {
        yield return new WaitForSeconds(0.2f);
        
        Player.transform.position = new Vector2(warpEntrance.transform.position.x,
                warpEntrance.transform.position.y);

        Camera.main.transform.position = new Vector3(0, -11, -5);

    }
}
