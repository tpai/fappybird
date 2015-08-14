using UnityEngine;
using System.Collections;

public class BirdPlayer : MonoBehaviour {

	Animator anim;
	Rigidbody2D rigid;

	public float fwdSpeed = 3.5f;
	public float flySpeed = 8f;

	void Start () {
		anim = GetComponent<Animator> ();
		rigid = GetComponent<Rigidbody2D> ();
	}
	
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
//			rigid.AddForce (Vector2.up * 500f);
			rigid.gravityScale = 1;
			rigid.velocity = new Vector2 (fwdSpeed, flySpeed);
		}
	}

	void FixedUpdate () {
		anim.SetFloat ("FlySpeed", rigid.velocity.y);
	}
}
