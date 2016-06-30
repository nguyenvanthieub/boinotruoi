using UnityEngine;
using System.Collections;

public class NextScene : MonoBehaviour {

	//public string value = "BanTay";

	void OnMouseDown() {
		if (PlayerPrefs.GetInt ("DisableMenuButton") == 0) {
			Mp3Manager.instance.SoundTurnOn ();
			effectClick ();
			string value = gameObject.transform.name;
			switch (value) {
			case "BanTay":
				PlayerPrefs.SetInt("Type", Const.BANTAY);
				break;
			case "Mat":
				PlayerPrefs.SetInt("Type", Const.MAT);
				break;
			case "NamSau":
				PlayerPrefs.SetInt("Type", Const.NAMSAU);
				break;
			case "NamTruoc":
				PlayerPrefs.SetInt("Type", Const.NAMTRUOC);
				break;
			case "NuSau":
				PlayerPrefs.SetInt("Type", Const.NUSAU);
				break;
			case "NuTruoc":
				PlayerPrefs.SetInt("Type", Const.NUTRUOC);
				break;
			}
			Application.LoadLevel ("Main");
		}
	}

	private void effectClick(){
		transform.localScale += new Vector3(0.1F, 0.1F, 0.1F);
		Invoke("scaleClick", 0.1F);
	}
	
	private void scaleClick(){
		transform.localScale -= new Vector3(0.1F, 0.1F, 0.1F);
	}
}
