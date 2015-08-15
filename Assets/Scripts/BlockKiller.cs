using UnityEngine;
using System.Collections;
                                                                                                            
public class BlockKiller : MonoBehaviour {

	int killBlockCount = 0;
	int killPillarCount = 0;

	void OnTriggerEnter2D (Collider2D other) {
		if (other.transform.parent.tag == "Scenery") {
			other.transform.parent.gameObject.Recycle ();

			if (other.transform.parent.name == "Block") {
				killBlockCount ++;
				if (killBlockCount % 3 == 2) {
//					GameObject.Find ("ScenerySpawner").GetComponent<ScenerySpawner>().SpawnBlock ();
					GameObject.Find ("ScenerySpawner").SendMessage ("SpawnBlock");
				}
			}

			if (other.transform.parent.name == "Pillar") {
				killPillarCount ++;
				if (killPillarCount % 20 == 10) {
					GameObject.Find ("ScenerySpawner").SendMessage ("SpawnPillar");
				}
			}
		}
	}
}
