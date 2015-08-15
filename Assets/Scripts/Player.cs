using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	bool isDead;
	Animator anim;
	Rigidbody2D rigid;

	void Start () {
		isDead = false;
		anim = GetComponent<Animator> ();
		rigid = GetComponent<Rigidbody2D> ();
	}

	void Update () {

		if (isDead)
			return;

		if (Input.anyKeyDown) {
			rigid.gravityScale = 1;
			rigid.velocity = new Vector2 (3.5f, 8f);
		}

		anim.SetFloat ("Speed", rigid.velocity.y);
	}

	void PlayerDie () {
		isDead = true;
		anim.SetTrigger ("Die");
	}
}
