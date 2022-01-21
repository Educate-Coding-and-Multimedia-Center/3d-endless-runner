using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour {

	[SerializeField]
	private GameObject[] enemy;

	private BoxCollider col;

	float x1, x2;

	void Awake () {

		col = GetComponent<BoxCollider>();

		x1 = transform.position.x - col.bounds.size.x / 2f;
		x2 = transform.position.x + col.bounds.size.x / 2f;

	}
	
	void Start () {
		StartCoroutine (Spawner(1f));
	}

	IEnumerator Spawner (float t) {

		yield return new WaitForSecondsRealtime (t);

		Vector3 temp = transform.position;
		temp.x = Random.Range (x1, x2);

		Instantiate (enemy[0], temp, Quaternion.identity);

		StartCoroutine (Spawner(Random.Range(0.5f, 1f)));

	}
}
