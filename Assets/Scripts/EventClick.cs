using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EventClick : MonoBehaviour {

	private GameObject Stars;

	void OnMouseDown(){
//		Stars = GameObject.Find("Stars");
//		
//		if (Stars == null) {
//			var obj = Resources.Load<GameObject> ("Prefabs/Stars");
//			if (obj != null) {
//				//GameObject en = Instantiate (obj) as GameObject;
//				GameObject en = Instantiate(obj, gameObject.transform.position, Quaternion.identity) as GameObject;
//				en.name = "Stars";
//			} else {
//				Debug.LogError ("Not find Object Stars in Resources/Prefabs/ --->> Please check again!");
//			}
//		}
	
		zoomOut ();

	}

	void OnMouseUp() {
		zoomIn ();
		Mp3Manager.instance.SoundTurnOn ();
		string name = gameObject.transform.name;
		print ("name " + name);

		GameManager.instance.ViewDialog (name);
	}

	float scale = 0.1f;
	Transform cha;

	private void zoomOut(){
		cha = transform.parent;
		cha.localScale += new Vector3(scale, scale, 0.1F);
	}
	
	private void zoomIn(){
		cha.localScale -= new Vector3(scale, scale, 0.1F);
	}
}
