using UnityEngine;
using System.Collections;

public class Pillar : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player") {
//			GameObject.Find ("Score").GetComponent<Score>().AddScore(1);
			Score.AddScore(1);
		}
	}
}
