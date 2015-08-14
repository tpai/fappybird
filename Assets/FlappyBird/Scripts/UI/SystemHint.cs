using UnityEngine;
using System.Collections;

public class SystemHint : MonoBehaviour {

	void Update () {
		if (Input.anyKeyDown) {
			Application.LoadLevel (Application.loadedLevelName);
		}
	}
}
