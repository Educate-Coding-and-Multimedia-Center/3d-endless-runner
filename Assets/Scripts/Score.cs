using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	private Text scoreText;

	private int score = 0;


	void Awake () {
		scoreText = GameObject.Find ("TextScore").GetComponent<Text> ();
	}
	

	void Start () {
		StartCoroutine (StartScore (0.2f));
	}

	IEnumerator StartScore(float time){
		yield return new WaitForSecondsRealtime (time);

		score++;
		scoreText.text = score.ToString ();

		StartCoroutine (StartScore(0.2f));
	}
}
