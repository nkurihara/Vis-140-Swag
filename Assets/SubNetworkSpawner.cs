using UnityEngine;
using System.Collections;

public class SubNetworkSpawner : MonoBehaviour {

	// Use this for initialization
	public Spawner[] spawners;
	public GameObject line;
	public int lines;
	public Material[] mats;
	void Start () {
		Invoke ("CreateSubNet", 1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void CreateSubNet() {
		for (int i = 0; i < lines; i++) {
			GameObject[] objs = new GameObject[spawners.Length];
			for (int j = 0; j < spawners.Length; j++) {

				GameObject[] spawnerObjs = spawners[j].objs;
				Debug.Log (spawnerObjs.Length);
				objs[j] = spawners[j].objs[ Random.Range(0, spawners[j].objs.Length )];
			}
			Lines.CreateLines(line, objs, mats, lines, this.gameObject.transform );

		}
	}
}
