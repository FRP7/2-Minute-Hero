using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    public Vector2 camSpeed;

    public float sTimeX;
    public float sTimeY;

    public float offsetX;
    public float offsetY;

    // Start is called before the first frame update
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref camSpeed.x, sTimeX);
        float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref camSpeed.y, sTimeY);

        transform.position = new Vector3((posX + offsetX), (posY + offsetY), transform.position.z);
    }
}