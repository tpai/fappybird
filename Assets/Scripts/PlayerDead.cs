using UnityEngine;
using System.Collections;

public class PlayerDead : MonoBehaviour {
	
	public Canvas systemHintCanvas;
	public SystemHint systemHintScript;

	public AudioSource audioSource;

	void OnCollisionEnter2D (Collision2D coll) {
		if (coll.collider.tag == "Enemy") {
			audioSource.Play ();
			SendMessage ("PlayerDie");
			systemHintCanvas.enabled = true;
			systemHintScript.enabled = true;
		}
	}
}
