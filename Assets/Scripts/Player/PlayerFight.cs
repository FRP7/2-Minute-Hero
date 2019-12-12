using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFight : MonoBehaviour
{
    enemy2_bullet projectile;

    //Bullet reflect stuff
    public GameObject bullet;
    public Transform bulletSpawn;


    public bool isReflected = false;

    //Cooldown time for the reflection
    float reflectCooldown = 2f;
    private float reflectCooldownTimer;

    // Update is called once per frame
    void FixedUpdate()
    {
        //Cooldown
        if (reflectCooldownTimer > 0)
            reflectCooldownTimer -= Time.deltaTime;

        if (reflectCooldownTimer < 0)
            reflectCooldownTimer = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Do damage
        if (collision.gameObject.tag == "enemy")
        {
            collision.gameObject.GetComponent<Health>().HP -= 1;
            Debug.Log("Hit enemy");
        }
            

        //bullet
        if (collision.gameObject.tag == "Projectile" && reflectCooldownTimer == 0)
        {
            Debug.Log("reflecting");
            Destroy(collision.gameObject);
            //Instantiate(bullet, bulletSpawn.position, Quaternion.identity);
            //sparkles and shit when projectile returns to the drone
        }
    }
}
