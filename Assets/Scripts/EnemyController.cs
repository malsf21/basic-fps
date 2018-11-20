using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	//private float time = 0;
	public float speed;
	private Rigidbody rb;
	private int health = 100;
	private Transform playerPos;
	// Use this for initialization
	void Start () {
		rb = this.gameObject.GetComponent<Rigidbody>();
	}

	public void AddPlayerPos(Transform pos){
		playerPos = pos;
	}

	// Update is called once per frame
	void Update () {
		if(playerPos != null){
			Vector3 diffPos = Vector3.Normalize(playerPos.position - transform.position);
			rb.AddForce(speed * new Vector3(diffPos.x, 0, diffPos.z));
		}
		if (health < 0){
			Destroy(this.gameObject);
		}
	}

	private void OnCollisionEnter(Collision collision){

		if(collision.gameObject.CompareTag("Bullet")){
			health -= 20;
		}
	}
}
