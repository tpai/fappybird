using UnityEngine;
using System.Collections;

public class BlockSpawner : MonoBehaviour {

	[SerializeField] GameObject blockPrefab;
	[SerializeField] GameObject pillarPrefab;
	int nowBlockIndex = 0;
	int nowPillarIndex = 0;

	void Start () {
		blockPrefab.CreatePool (6);
		pillarPrefab.CreatePool (40);
		SpawnBlock ();
		SpawnPillar ();
	}

	void SpawnBlock () {
		for(int i=nowBlockIndex+1;i<=nowBlockIndex+3;i++) {
			GameObject obj = blockPrefab.Spawn (new Vector3(20.4f * i, 0f, 0f), Quaternion.identity);
			obj.name = "Block";
		}
		nowBlockIndex += 3;
	}

	void SpawnPillar () {
		for(int i=nowPillarIndex+1;i<=nowPillarIndex+20;i++) {
			GameObject obj = pillarPrefab.Spawn (new Vector3(-1f + 5f * i, Random.Range(0.3f, 3.3f), 0f), Quaternion.identity);
			obj.name = "Pillar";
		}
		nowPillarIndex += 20;
	}
}
