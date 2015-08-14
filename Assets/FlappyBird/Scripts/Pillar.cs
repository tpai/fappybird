using UnityEngine;
using System.Collections;

public class Pillar : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player") {
			Score.AddScore (1);
		}
	}
}
