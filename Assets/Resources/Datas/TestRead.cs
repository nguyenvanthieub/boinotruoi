using UnityEngine;
using System.Collections;

public class TestRead : MonoBehaviour {

	public DataStore dataStore;

	// Use this for initialization
	void Start () {
		foreach (var ds in dataStore.datas) {
			print(">> " + ds.Name + " " + ds.Value);
		}
	}

}
