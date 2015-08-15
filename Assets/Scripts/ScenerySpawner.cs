using UnityEngine;
using System.Collections;

public class ScenerySpawner : MonoBehaviour {

	public GameObject blockPrefab;
	public GameObject pillarPrefab;

	int nowBlockIndex = 0;
	int nowPillarIndex = 0;

	void Start () {
		blockPrefab.CreatePool (6);
		SpawnBlock ();

		pillarPrefab.CreatePool (20);
		SpawnPillar ();
	}

	public void SpawnBlock () {
		for (int i=nowBlockIndex + 1; i<=nowBlockIndex + 3; i++) {
			GameObject block = blockPrefab.Spawn(new Vector3 (20.4f * i, 0f, 0f), Quaternion.identity);
			block.name = "Block";
		}
		nowBlockIndex += 3;
	}

	public void SpawnPillar () {
		for (int i=nowPillarIndex + 1; i<=nowPillarIndex + 20; i++) {
			GameObject pillar = pillarPrefab.Spawn(new Vector3 (7f * i - 4f, Random.Range(-2f, 2f), 0f), Quaternion.identity);
			pillar.name = "Pillar";
		}
		nowPillarIndex += 20;
	}
}
