using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2_shoot : MonoBehaviour {

    //public Vector2 trigger1;
    public Transform trigger1;

    [SerializeField] GameObject bullet;
    public float speed = 100f;

    public float fireRate;
    public float nextFire;
    
    // Use this for initialization
    void Start()
    {
        // bullet.GetComponent<Rigidbody2D>();
        fireRate = 1f;
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update() {

	
    }
	
	public void Fire()
	{
		Debug.Log("Enemy 2 shoots");
       /*  GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity)
         as GameObject;
         Rigidbody2D instBulletRigidbody = instBullet.GetComponent<Rigidbody2D>();
        Vector2 shoot = (trigger1.position - bullet.transform.position).normalized;
        instBulletRigidbody.AddForce(shoot * 500.0f);*/

        if (Time.time > nextFire) {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }

    }

}