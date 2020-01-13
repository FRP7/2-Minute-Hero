using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2_shoot : MonoBehaviour
{
    public enemy2_trigger trigger;
    Animator myAnim;

    [SerializeField]
    private GameObject bullet;

    [SerializeField]
    private Transform spawnPoint;

    public float speed = 100f;

    private float timeBtwShots;
    public float startTimeBtwShots;

    // Use this for initialization
    void Start()
    {
        // bullet.GetComponent<Rigidbody2D>();
        timeBtwShots = startTimeBtwShots;

        myAnim = GetComponent<Animator>();

        trigger = GameObject.Find("enemy2_trigger").GetComponent<enemy2_trigger>();
        spawnPoint = GameObject.Find("Spawnpoint_drone").transform;
        //trigger = GetComponent<enemy2_trigger>();
    }

    private void FixedUpdate()
    {
        if (timeBtwShots <= 0 && trigger.canShoot == true)
        {
            Instantiate(bullet, spawnPoint.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShots;
        }

        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }

    //public void Fire()
    //{
    //    Debug.Log("Enemy 2 shoots");
    //    /*  GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity)
    //      as GameObject;
    //      Rigidbody2D instBulletRigidbody = instBullet.GetComponent<Rigidbody2D>();
    //     Vector2 shoot = (trigger1.position - bullet.transform.position).normalized;
    //     instBulletRigidbody.AddForce(shoot * 500.0f);*/



    //    //deves meter algures por aqui a animação da arma do robot a disparar
    //    myAnim.SetBool("isAttacking", true);
    //    myAnim.SetBool("isCharging", true);
    //    myAnim.SetBool("readyToShoot", true);
    //}

}