using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	private float time = 0;
	public float speed;
	private Rigidbody rb;
	private int health = 100;
	// Use this for initialization
	void Start () {
		rb = this.gameObject.GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {
		if (time < 2){
			rb.velocity = new Vector3(speed, rb.velocity.y, 0);
		}
		else if (time < 4){
			rb.velocity = new Vector3(-speed, rb.velocity.y, 0);
		}
		else{
			time = 0;
		}
		if (health < 0){
			Destroy(this.gameObject);
		}
		time += Time.deltaTime;
	}

	private void OnCollisionEnter(Collision collision){
		if(collision.gameObject.CompareTag("Bullet")){
			health -= 10;
		}
	}
}
