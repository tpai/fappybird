using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BirdPlayerDeath : MonoBehaviour {

	[SerializeField] AudioSource audioSource;
	[SerializeField] Text systemHintText;
	[SerializeField] SystemHint systemHintScript;
	[SerializeField] Image panelImage;

	void OnCollisionEnter2D (Collision2D coll) {
		if (coll.collider.tag == "Enemy") {
			audioSource.Play ();
			GetComponent<Animator>().SetTrigger ("Die");
			GetComponent<BirdPlayer>().enabled = false;
			panelImage.enabled = true;
			systemHintText.enabled = true;
			systemHintScript.enabled = true;
		}
	}
}
