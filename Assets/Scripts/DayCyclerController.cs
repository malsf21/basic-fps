using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayCyclerController : MonoBehaviour {
	public int dayLengthSeconds = 120;
	private float initX;
	// Use this for initialization
	void Start () {
		initX = transform.rotation.x;
	}

	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.Euler(initX + (360*Time.time)/dayLengthSeconds, transform.rotation.y, transform.rotation.z);
	}
}
