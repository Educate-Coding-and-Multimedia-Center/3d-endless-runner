using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

	public float speed = 10f;
	public float speedT = 5f;

	void Start () {
		
	}

	void Update () {
		// transform.Rotate (new Vector3(5, 10, -5));

		// transform.Translate (new Vector3(0, 1, 1) * Time.deltaTime);

		if (Input.GetKey(KeyCode.A)) {
			transform.Rotate (new Vector3(-2, 0, 0) * speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.D)) {
			transform.Rotate (new Vector3(2, 0, 0) * speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.W)) {
			transform.Translate (new Vector3(0, 2, 0) * speedT * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.S)) {
			transform.Translate (new Vector3(0, -2, 0) * speedT * Time.deltaTime);
		}
	}
}
