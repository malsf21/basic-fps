using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour {

    public GameObject projectile;
    public Transform bulletSpawn;
    private bool canFire;
    private float time = 0;
    public float timeBetweenShots = 0.2f;

	// Update is called once per frame
	void Update () {
    if(Input.GetButton("Fire1") && canFire){
      Rigidbody clone;
      clone = Instantiate(projectile.GetComponent<Rigidbody>(), bulletSpawn.position, bulletSpawn.rotation);
      clone.velocity = transform.TransformDirection(Vector3.forward * 50);
      canFire = false;
      time = 0;
    }
    if(time >= timeBetweenShots){
      canFire = true;
    }
    else{
      time += Time.deltaTime;
    }
	}
}
