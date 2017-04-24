using UnityEngine;
using System.Collections;

public class Mp3Manager : MonoBehaviour {

	public static Mp3Manager instance;
	
	public GameObject sound;
	public GameObject music;

	void Awake(){
		instance = this;
		DontDestroyOnLoad (this);
		PlayerPrefs.SetInt("sound", 1);
		PlayerPrefs.SetInt("music", 1);
		PlayerPrefs.SetInt("first", 1);
	}

	void Start(){
		if (PlayerPrefs.GetInt("first") == 1) {
			PlayerPrefs.SetInt("first", 0);
			MusicTurnOn();
		}
	}

//	public void SoundClick(){
//		if (PlayerPrefs.GetInt ("sound") == 1) {
//			SoundTurnOn();
//		} 
//	}
//
//	public void MusicClick(){
//		if (PlayerPrefs.GetInt ("music") == 1) {
//			MusicTurnOn();
//		}
//	}

	public void SoundTurnOn(){
		if (PlayerPrefs.GetInt ("sound") == 1) {
			AudioSource audio = sound.GetComponent<AudioSource> ();
			audio.Play ();
		}
	}
	
	public void SoundTurnOff(){
		if (PlayerPrefs.GetInt ("sound") == 0) {
			AudioSource audio = music.GetComponent<AudioSource> ();
			audio.Stop ();
		}
	}

	public void MusicTurnOn(){
		if (PlayerPrefs.GetInt ("music") == 1) {
			AudioSource audio = music.GetComponent<AudioSource> ();
			audio.Play ();
		}
	}
	
	public void MusicTurnOff(){
		if (PlayerPrefs.GetInt ("music") == 0) {
			AudioSource audio = music.GetComponent<AudioSource> ();
			audio.Stop ();
		}
	}
}
