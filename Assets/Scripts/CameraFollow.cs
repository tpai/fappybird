using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public float offsetX = 3f;
	Transform target;

	void Start () {
		target = GameObject.Find ("Player").GetComponent<Transform> ();
	}
	
	void Update () {
		transform.position = new Vector3 (
			Mathf.Clamp(target.position.x + offsetX, 0f, float.MaxValue),
			transform.position.y,
			transform.position.z
		);
	}
}
