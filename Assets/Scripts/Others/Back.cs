using UnityEngine;
using System.Collections;

public class Back : MonoBehaviour {

	void OnMouseUp() {
		Mp3Manager.instance.SoundTurnOn ();
		effectClick ();
		Application.LoadLevel ("Menu");
	}

	private void effectClick(){
		transform.localScale += new Vector3(0.1F, 0.1F, 0.1F);
		Invoke("scaleClick", 0.1F);
	}
	
	private void scaleClick(){
		transform.localScale -= new Vector3(0.1F, 0.1F, 0.1F);
	}
}
