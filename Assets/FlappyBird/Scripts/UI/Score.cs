using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	public static int nowScore = 0;
	public static void AddScore (int amt) {
		nowScore += amt;
	}

	void Start () {
		Score.nowScore = 0;
	}

	void FixedUpdate () {
		GetComponent<Text> ().text = nowScore.ToString();
	}
}
