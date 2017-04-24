using UnityEngine;

public class CheckData : MonoBehaviour
{
	private GameObject Mp3;
	private GameObject Facebook;
	
	void Awake()
	{
		Mp3 = GameObject.Find("Mp3");

		if (Mp3 == null) {
			var obj = Resources.Load<GameObject> ("Prefabs/Mp3");
			if (obj != null) {
				GameObject en = Instantiate (obj) as GameObject;
				en.name = "Mp3";
			} else {
				Debug.LogError ("Not find Object Mp3 in Resources/Prefabs/ --->> Please check again!");
			}
		}


		Facebook = GameObject.Find("Facebook");
		
		if (Facebook == null) {
			var obj = Resources.Load<GameObject> ("Prefabs/Facebook");
			if (obj != null) {
				GameObject en = Instantiate (obj) as GameObject;
				en.name = "Facebook";
			} else {
				Debug.LogError ("Not find Object Facebook in Resources/Prefabs/ --->> Please check again!");
			}
		}

	}
	
}