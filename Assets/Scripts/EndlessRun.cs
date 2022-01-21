using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndlessRun : MonoBehaviour {

	public float speed = 5f;
	public float edgeMax = 3.5f;
	public float edgeMin = -3.5f;

	public AudioSource punchSound;

	// Use this for initialization
	void Start () {
		punchSound = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 edgeObject = transform.position;

		if (Input.GetKey(KeyCode.A)) {
			transform.Translate (new Vector3 (-1, 0, 0) * speed * Time.deltaTime);
			if (edgeObject.x < edgeMin) {
				transform.Translate (new Vector3 (1, 0, 0) * speed * Time.deltaTime);
			}
		}

		if (Input.GetKey(KeyCode.D)) {
			transform.Translate (new Vector3 (1, 0, 0) * speed * Time.deltaTime);
			if (edgeObject.x > edgeMax) {
				transform.Translate (new Vector3 (-1, 0, 0) * speed * Time.deltaTime);
			}
		}
			
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Enemy"){
			col.gameObject.SetActive (false);
			punchSound.Play ();
			StartCoroutine (RestartGame());
		}
	}

	IEnumerator RestartGame() {
		yield return new WaitForSecondsRealtime (1f);
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}
}
