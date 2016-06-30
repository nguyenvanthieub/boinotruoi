using UnityEngine;
using System.Collections;

public class SettingManager : MonoBehaviour {

	public GameObject setting;
	public GameObject tut;
	public GameObject quit;

	public static SettingManager Instance;

	void Awake(){
		Instance = this;
		PlayerPrefs.SetInt("DisableMenuButton", 0);
	}

	public void ViewSetting(){
		setting.SetActive(true);
	}

	public void HideSetting(){
		setting.SetActive(false);
	}

	public void ViewTut(){
		tut.SetActive(true);
	}
	
	public void HideTut(){
		tut.SetActive(false);
	}

	public void ViewQuit(){
		PlayerPrefs.SetInt("DisableMenuButton", 1);
		quit.SetActive(true);
	}
	
	public void HideQuit(){
		Mp3Manager.instance.SoundTurnOn ();
		PlayerPrefs.SetInt("DisableMenuButton", 0);
		print ("Hide Quit");
		quit.SetActive(false);
	}

	public void QuitGame(){
		Mp3Manager.instance.SoundTurnOn ();
		print ("Quit Game = true");
		Application.Quit(); 
	}

}
