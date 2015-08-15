using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	public static int nowScore;
	Text scoreText;
	
	void Start () {
		nowScore = 0;
		scoreText = GetComponent<Text> ();
	}

	void Update () {
		scoreText.text = nowScore.ToString ();
	}

	public static void AddScore (int amt) {
		nowScore += amt; // nowScore = nowScore + amt;
	}
}
