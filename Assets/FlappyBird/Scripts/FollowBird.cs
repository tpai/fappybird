using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class FollowBird : NetworkBehaviour {

	Transform target;
	public float speed = 1f;
	public float offsetDistance = 4f;

	void Start () {
		target = GameObject.Find ("BirdPlayer").transform;
	}

	void FixedUpdate () {
		if (target == null)
			return;
//		transform.position = new Vector3 (target.position.x, transform.position.y, -10f);
		transform.position = Vector3.Lerp (
			transform.position, 
			new Vector3 (
				Mathf.Clamp (target.position.x + offsetDistance, 0f, float.MaxValue), 
				transform.position.y, 
				-10f
			),
			Time.deltaTime * speed
		);
	}
}
