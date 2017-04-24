using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {

	private bool isSetting = true;

//	void Update () {
//		if (Input.GetKeyDown(KeyCode.Escape)) 
//			Application.Quit(); 
//	}

	void OnMouseDown() {
		if (PlayerPrefs.GetInt ("DisableMenuButton") == 0) {
			Mp3Manager.instance.SoundTurnOn ();
			effectClick ();
			string value = gameObject.transform.name;
			switch (value) {
			case "VongTron":
				print("Vong Tron");
				Application.OpenURL(Const.linkApp);
				break;
			case "BackQuit":
				print("Back Quit");
				SettingManager.Instance.ViewQuit();
				break;
			case "HuongDan":
				print("Huong Dan");
				SettingManager.Instance.ViewTut();
				break;
			case "DanhGia":
				print("Danh Gia");
				Application.OpenURL(Const.linkApp);
				break;
			case "Main":
				print("Setting");
				if (isSetting) {
					isSetting = false;
					SettingManager.Instance.ViewSetting();
				} else {
					isSetting = true;
					SettingManager.Instance.HideSetting();
				}
				
				break;
			}
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
