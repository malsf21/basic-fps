using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public GameObject player;
	public GameObject enemy;

	public int maxEnemies;
	public Transform[] spawnPositions;

	private int enemyCount;
	private List<GameObject> enemies;
	// Use this for initialization
	void Start () {
		enemies = new List<GameObject>();
	}

	// Update is called once per frame
	void Update () {
		if(enemyCount < maxEnemies){
			SpawnEnemy();
		}
		for (int i = enemies.Count - 1; i >= 0; i--){
			if (enemies[i] == null){
				enemies.RemoveAt(i);
				enemyCount--;
			}
		}
	}

	void SpawnEnemy(){
		Transform spawnPos = spawnPositions[Random.Range(0, spawnPositions.Length)];
		GameObject e = Instantiate(enemy, spawnPos);
		enemies.Add(e);
		e.GetComponent<EnemyController>().AddPlayerPos(player.transform);
		enemyCount++;
	}
}
